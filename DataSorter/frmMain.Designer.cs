namespace DataSorter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtHTMLPath = new System.Windows.Forms.TextBox();
            this.btnSelectHTML = new System.Windows.Forms.Button();
            this.btnCreateHTML = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGoogle = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSheetId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.txtStartCell = new System.Windows.Forms.TextBox();
            this.txtEndCell = new System.Windows.Forms.TextBox();
            this.btnReadFromGoogle = new System.Windows.Forms.Button();
            this.tpReviewData = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tcMain.SuspendLayout();
            this.tpGoogle.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tpReviewData.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "HTML Output Directory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHTMLPath
            // 
            this.txtHTMLPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHTMLPath.Location = new System.Drawing.Point(153, 3);
            this.txtHTMLPath.Name = "txtHTMLPath";
            this.txtHTMLPath.ReadOnly = true;
            this.txtHTMLPath.Size = new System.Drawing.Size(457, 20);
            this.txtHTMLPath.TabIndex = 3;
            // 
            // btnSelectHTML
            // 
            this.btnSelectHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectHTML.Location = new System.Drawing.Point(616, 3);
            this.btnSelectHTML.Name = "btnSelectHTML";
            this.btnSelectHTML.Size = new System.Drawing.Size(94, 24);
            this.btnSelectHTML.TabIndex = 7;
            this.btnSelectHTML.Text = "Select";
            this.btnSelectHTML.UseVisualStyleBackColor = true;
            this.btnSelectHTML.Click += new System.EventHandler(this.btnSelectHTML_Click);
            // 
            // btnCreateHTML
            // 
            this.btnCreateHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateHTML.Location = new System.Drawing.Point(3, 408);
            this.btnCreateHTML.Name = "btnCreateHTML";
            this.btnCreateHTML.Size = new System.Drawing.Size(707, 24);
            this.btnCreateHTML.TabIndex = 8;
            this.btnCreateHTML.Text = "Create HTML File";
            this.btnCreateHTML.UseVisualStyleBackColor = true;
            this.btnCreateHTML.Click += new System.EventHandler(this.btnCreateHTML_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGoogle);
            this.tcMain.Controls.Add(this.tpReviewData);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(727, 467);
            this.tcMain.TabIndex = 1;
            // 
            // tpGoogle
            // 
            this.tpGoogle.Controls.Add(this.tableLayoutPanel4);
            this.tpGoogle.Location = new System.Drawing.Point(4, 22);
            this.tpGoogle.Name = "tpGoogle";
            this.tpGoogle.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoogle.Size = new System.Drawing.Size(719, 441);
            this.tpGoogle.TabIndex = 1;
            this.tpGoogle.Text = "Import From Google Sheets";
            this.tpGoogle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtAppName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtSheetId, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtSheetName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtStartCell, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtEndCell, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnReadFromGoogle, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(713, 435);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sheet Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAppName
            // 
            this.txtAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAppName.Location = new System.Drawing.Point(155, 35);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(554, 20);
            this.txtAppName.TabIndex = 4;
            this.txtAppName.Text = "Sheets Test";
            this.txtAppName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAppName_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "App Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSheetId
            // 
            this.txtSheetId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSheetId.Location = new System.Drawing.Point(155, 4);
            this.txtSheetId.Name = "txtSheetId";
            this.txtSheetId.Size = new System.Drawing.Size(554, 20);
            this.txtSheetId.TabIndex = 6;
            this.txtSheetId.Text = "1d35X8k_0TZ8q02WwLHlEViV4Nb6ZiJ4VS9YiDzNFIXc";
            this.txtSheetId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSheetId_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sheet Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Start Cell";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "End Cell";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSheetName.Location = new System.Drawing.Point(155, 66);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(554, 20);
            this.txtSheetName.TabIndex = 10;
            this.txtSheetName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSheetName_KeyUp);
            // 
            // txtStartCell
            // 
            this.txtStartCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStartCell.Location = new System.Drawing.Point(155, 97);
            this.txtStartCell.Name = "txtStartCell";
            this.txtStartCell.Size = new System.Drawing.Size(554, 20);
            this.txtStartCell.TabIndex = 11;
            this.txtStartCell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartCell_KeyUp);
            // 
            // txtEndCell
            // 
            this.txtEndCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndCell.Location = new System.Drawing.Point(155, 128);
            this.txtEndCell.Name = "txtEndCell";
            this.txtEndCell.Size = new System.Drawing.Size(554, 20);
            this.txtEndCell.TabIndex = 12;
            this.txtEndCell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEndCell_KeyUp);
            // 
            // btnReadFromGoogle
            // 
            this.btnReadFromGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadFromGoogle.Location = new System.Drawing.Point(155, 159);
            this.btnReadFromGoogle.Name = "btnReadFromGoogle";
            this.btnReadFromGoogle.Size = new System.Drawing.Size(554, 24);
            this.btnReadFromGoogle.TabIndex = 13;
            this.btnReadFromGoogle.Text = "Import From Google";
            this.btnReadFromGoogle.UseVisualStyleBackColor = true;
            this.btnReadFromGoogle.Click += new System.EventHandler(this.btnReadFromGoogle_Click);
            // 
            // tpReviewData
            // 
            this.tpReviewData.Controls.Add(this.tableLayoutPanel5);
            this.tpReviewData.Location = new System.Drawing.Point(4, 22);
            this.tpReviewData.Name = "tpReviewData";
            this.tpReviewData.Padding = new System.Windows.Forms.Padding(3);
            this.tpReviewData.Size = new System.Drawing.Size(719, 441);
            this.tpReviewData.TabIndex = 2;
            this.tpReviewData.Text = "Review Data";
            this.tpReviewData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgvImport, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCreateHTML, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(713, 435);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(3, 3);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            this.dgvImport.RowHeadersVisible = false;
            this.dgvImport.Size = new System.Drawing.Size(707, 369);
            this.dgvImport.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtHTMLPath, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectHTML, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 375);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(713, 30);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 467);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tcMain.ResumeLayout(false);
            this.tpGoogle.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tpReviewData.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHTMLPath;
        private System.Windows.Forms.Button btnSelectHTML;
        private System.Windows.Forms.Button btnCreateHTML;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGoogle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSheetId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.TextBox txtStartCell;
        private System.Windows.Forms.TextBox txtEndCell;
        private System.Windows.Forms.Button btnReadFromGoogle;
        private System.Windows.Forms.TabPage tpReviewData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvImport;
    }
}