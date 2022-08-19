
namespace Car_Parking
{
    partial class CarParking
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
            this.listBoxPlate = new System.Windows.Forms.ListBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLinearSearch = new System.Windows.Forms.Button();
            this.buttonBinarySearch = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPlate
            // 
            this.listBoxPlate.FormattingEnabled = true;
            this.listBoxPlate.ItemHeight = 20;
            this.listBoxPlate.Location = new System.Drawing.Point(38, 38);
            this.listBoxPlate.Name = "listBoxPlate";
            this.listBoxPlate.Size = new System.Drawing.Size(178, 444);
            this.listBoxPlate.TabIndex = 0;
            this.tooltip.SetToolTip(this.listBoxPlate, "The rego plate data list");
            this.listBoxPlate.SelectedIndexChanged += new System.EventHandler(this.listBoxPlate_SelectedIndexChanged);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(225, 78);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(126, 26);
            this.textBoxInput.TabIndex = 1;
            this.tooltip.SetToolTip(this.textBoxInput, "Enter the rego plate");
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(399, 78);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(117, 45);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.tooltip.SetToolTip(this.buttonOpen, "Select and open the data from pre-saved text files");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 394);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 45);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.tooltip.SetToolTip(this.buttonSave, "Save the data to the text file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(236, 122);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.tooltip.SetToolTip(this.buttonAdd, "Add a rego plate to the list box");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(236, 165);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 43);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.tooltip.SetToolTip(this.buttonEdit, "Select a rego plate from the list box, replace it with the rego plate in the text" +
        " box");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(236, 214);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 51);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.tooltip.SetToolTip(this.buttonDelete, "Select a rego plate from the list box and remove it");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLinearSearch
            // 
            this.buttonLinearSearch.Location = new System.Drawing.Point(374, 220);
            this.buttonLinearSearch.Name = "buttonLinearSearch";
            this.buttonLinearSearch.Size = new System.Drawing.Size(154, 38);
            this.buttonLinearSearch.TabIndex = 8;
            this.buttonLinearSearch.Text = "Linear Search";
            this.tooltip.SetToolTip(this.buttonLinearSearch, "Type the plate into the text box using linear search ");
            this.buttonLinearSearch.UseVisualStyleBackColor = true;
            this.buttonLinearSearch.Click += new System.EventHandler(this.buttonLinearSearch_Click);
            // 
            // buttonBinarySearch
            // 
            this.buttonBinarySearch.Location = new System.Drawing.Point(374, 280);
            this.buttonBinarySearch.Name = "buttonBinarySearch";
            this.buttonBinarySearch.Size = new System.Drawing.Size(154, 40);
            this.buttonBinarySearch.TabIndex = 9;
            this.buttonBinarySearch.Text = "Binary Search";
            this.tooltip.SetToolTip(this.buttonBinarySearch, "Type the plate into the text box using binary search");
            this.buttonBinarySearch.UseVisualStyleBackColor = true;
            this.buttonBinarySearch.Click += new System.EventHandler(this.buttonBinarySearch_Click);
            // 
            // buttonTag
            // 
            this.buttonTag.Location = new System.Drawing.Point(236, 271);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(98, 49);
            this.buttonTag.TabIndex = 10;
            this.buttonTag.Text = "Tag";
            this.tooltip.SetToolTip(this.buttonTag, "Select a rego plate from the list box and mark it");
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vehicle Plate Details";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(374, 394);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(142, 45);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.tooltip.SetToolTip(this.buttonReset, "Clear all the data items from the list");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 21);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusStrip.Location = new System.Drawing.Point(0, 514);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.StatusStrip.Size = new System.Drawing.Size(596, 28);
            this.StatusStrip.TabIndex = 13;
            // 
            // CarParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 542);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.buttonBinarySearch);
            this.Controls.Add(this.buttonLinearSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.listBoxPlate);
            this.Name = "CarParking";
            this.Text = "CarParking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarParking_FormClosed);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlate;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLinearSearch;
        private System.Windows.Forms.Button buttonBinarySearch;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip StatusStrip;
    }
}

