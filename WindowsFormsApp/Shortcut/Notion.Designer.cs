
namespace Shortcut
{
    partial class NotionForm
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
            this.components = new System.ComponentModel.Container();
            this.shortcutDataSet = new Shortcut.shortcutDataSet();
            this.notionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notionTableAdapter = new Shortcut.shortcutDataSetTableAdapters.notionTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shortcutDataSet
            // 
            this.shortcutDataSet.DataSetName = "shortcutDataSet";
            this.shortcutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notionBindingSource
            // 
            this.notionBindingSource.DataMember = "notion";
            this.notionBindingSource.DataSource = this.shortcutDataSet;
            // 
            // notionTableAdapter
            // 
            this.notionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.notionBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(784, 361);
            this.dataGridView.TabIndex = 0;
            // 
            // NotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridView);
            this.Name = "NotionForm";
            this.Text = "notion";
            this.Load += new System.EventHandler(this.NotionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shortcutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private shortcutDataSet shortcutDataSet;
        private System.Windows.Forms.BindingSource notionBindingSource;
        private shortcutDataSetTableAdapters.notionTableAdapter notionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}