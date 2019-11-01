using FileSizeReader.Properties;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;

namespace FileSizeReader
{
    public partial class MainForm : Form
    {
        ViewModelOperation _viewModelOperation;
        BindingList<ReadFileResult> _filesSize;
        public MainForm()
        {
            InitializeComponent();
            InitComponent();
            InitGrid();
        }

        #region Event
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var fldDialog = new FolderBrowserDialog())
            {
                if (fldDialog.ShowDialog() == DialogResult.OK)
                {
                    lbPath.Text = fldDialog.SelectedPath;
                    _viewModelOperation.Path = fldDialog.SelectedPath;
                    SetEnablingBtn(true, false, true);
                    _filesSize.Clear();
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetEnablingBtn(false, true);
            _viewModelOperation.CancelToken();
            _viewModelOperation.StartProcess();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _viewModelOperation._cancelTokenSource.Cancel();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _viewModelOperation._cancelTokenSource.Cancel();
        }
        #endregion

        #region Methods
        void InitComponent()
        {
            _viewModelOperation = new ViewModelOperation();
            _viewModelOperation._updateGrid += CallBackUpdateGrid;
            _viewModelOperation._cancelMessage += CancelMessage;
            _viewModelOperation._updateControls += CallBackUpdateControl;
            _viewModelOperation._finishOperation += CallBackFinishOperation;
            this.FormClosing += MainForm_FormClosing;
            _filesSize = new BindingList<ReadFileResult>();
            gridFiles.DataSource = _filesSize;
        }
        void InitGrid()
        {
            gridFiles.Columns["Name"].HeaderText = Resources.Name;
            gridFiles.Columns["ByteSize"].HeaderText = Resources.ByteSize;
            gridFiles.Columns["ErrorMessage"].HeaderText = Resources.ErrorMessage;
            gridFiles.Columns["Name"].Width = 400;
            gridFiles.Columns["ByteSize"].Width = 100;
            gridFiles.Columns["ErrorMessage"].Width = 350;
        }
        void SetEnablingBtn(bool btnSt = false, bool btnCan = false, bool btnOp = false)
        {
            Action action = () =>
            {
                btnStart.Enabled = btnSt;
                btnCancel.Enabled = btnCan;
                btnOpen.Enabled = btnOp;
            };
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    Invoke(action);
                }));
            }
            else
                action();
        }
        void CallBackUpdateGrid(ReadFileResult result) 
        {
            Action action = () =>
            {
                _filesSize.Insert(_filesSize.Count < 1 ? 0 : _filesSize.Count - 1, result);
                progress.Value += 1;
                lbProcessed.Text = $"Обработано: {_filesSize.Count}";
            };

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    Invoke(action);
                }));
            }
            else
                action();
        }
        void CallBackUpdateControl(List<string> listReadFiles)
        {
            Action action = () =>
            {
                progress.Maximum = listReadFiles.Count;
                lbTotal.Text = $"Всего: {listReadFiles.Count}";
            };

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    Invoke(action);
                }));
            }
            else
                action();
        }
        void CancelMessage(string message) 
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK);
            SetEnablingBtn(false, false, true);
        }
        void CallBackFinishOperation()
        {
            Action action = () =>
            {
                progress.Value = 0;
                btnCancel.Enabled = false;
                btnStart.Enabled = false;
                btnOpen.Enabled = true;
            };

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    Invoke(action);
                }));
            }
            else
                action();
        }
        #endregion
    }
}
