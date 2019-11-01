using FileOperations;
using FileOperations.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModel
{
    public class ViewModelOperation
    {
        #region fields
        List<string> _filePath;
        IGetFilesPath _getFilePath;
        IReadFile _readFile;
        IWriteFile _writeFile;
        public CancellationTokenSource _cancelTokenSource;
        CancellationToken _token;
        public event UpdateControls _updateControls;
        public event UpdateGrid _updateGrid;
        public event Message _cancelMessage;
        public event FinishOperation _finishOperation;
        BindingList<ReadFileResult> _filesSize;
        #endregion

        #region property
        public string Path { get; set; }
        #endregion

        #region delegates
        public delegate void FinishOperation();
        public delegate void UpdateGrid(ReadFileResult result);
        public delegate void Message(string result);
        public delegate void UpdateControls(List<string> listReadFiles);
        #endregion

        #region property
        public ViewModelOperation()
        {
            //CancelToken();
            _getFilePath = new GetPathAllFiles();
            _readFile = new BinaryReadFile();
            _writeFile = new WriteXmlFile();
            _filesSize = new BindingList<ReadFileResult>();
        }
        public void StartProcess()
        {
            try
            {
                var task = Task.Factory.StartNew(get => GetFilesPath(), TaskContinuationOptions.OnlyOnRanToCompletion)
                    .ContinueWith(read => ReadFiles(), TaskContinuationOptions.OnlyOnRanToCompletion)
                    .ContinueWith(write => WriteFile(), TaskContinuationOptions.OnlyOnRanToCompletion)
                    .ContinueWith(finish => _finishOperation.Invoke());

            }
            catch (OperationCanceledException ex)
            {
                _cancelMessage("Прервано пользователем");
            }

        }
        List<string> GetFilesPath()
        {
            if (string.IsNullOrEmpty(Path))
                return new List<string>();
            if (_filePath != null && _filePath.Count > 0)
                _filePath.Clear();
            _filePath = _getFilePath.GetFilesPath(Path);
            _updateControls(_filePath);
            return _filePath;
        }
        void ReadFiles()
        {
            try
            {
                foreach (var item in _filePath)
                {
                    if (_token.IsCancellationRequested)
                        _token.ThrowIfCancellationRequested();

                    var result = _readFile.ReadFile(item);
                    _updateGrid(result);
                    _filesSize.Add(result);
                }
            }
            catch (OperationCanceledException ex)
            {
                _cancelMessage("Прервано пользователем");
            }

        }
        void WriteFile()
        {
            _writeFile.WriteFile(Path, _filesSize);
        }

        public void CancelToken()
        {
            _cancelTokenSource = new CancellationTokenSource();
            _token = _cancelTokenSource.Token;
        }
        #endregion
    }
}
