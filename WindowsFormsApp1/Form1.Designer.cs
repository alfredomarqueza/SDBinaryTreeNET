namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_Serialize = new System.Windows.Forms.Button();
            this.treeViewBinaryTree = new System.Windows.Forms.TreeView();
            this.txtBox_serializedText = new System.Windows.Forms.TextBox();
            this.btn_Deserialize = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Serialize
            // 
            this.btn_Serialize.Location = new System.Drawing.Point(284, 131);
            this.btn_Serialize.Name = "btn_Serialize";
            this.btn_Serialize.Size = new System.Drawing.Size(97, 23);
            this.btn_Serialize.TabIndex = 0;
            this.btn_Serialize.Text = ">> Serialize >>";
            this.btn_Serialize.UseVisualStyleBackColor = true;
            this.btn_Serialize.Click += new System.EventHandler(this.btn_Serialize_Click);
            // 
            // treeViewBinaryTree
            // 
            this.treeViewBinaryTree.Location = new System.Drawing.Point(68, 101);
            this.treeViewBinaryTree.Name = "treeViewBinaryTree";
            this.treeViewBinaryTree.Size = new System.Drawing.Size(176, 158);
            this.treeViewBinaryTree.TabIndex = 2;
            // 
            // txtBox_serializedText
            // 
            this.txtBox_serializedText.Location = new System.Drawing.Point(422, 159);
            this.txtBox_serializedText.Name = "txtBox_serializedText";
            this.txtBox_serializedText.Size = new System.Drawing.Size(171, 20);
            this.txtBox_serializedText.TabIndex = 3;
            this.txtBox_serializedText.Text = "[1,2,3,null,null,4,5]";
            // 
            // btn_Deserialize
            // 
            this.btn_Deserialize.Location = new System.Drawing.Point(284, 189);
            this.btn_Deserialize.Name = "btn_Deserialize";
            this.btn_Deserialize.Size = new System.Drawing.Size(97, 23);
            this.btn_Deserialize.TabIndex = 4;
            this.btn_Deserialize.Text = "<< Deserialize <<";
            this.btn_Deserialize.UseVisualStyleBackColor = true;
            this.btn_Deserialize.Click += new System.EventHandler(this.btn_Deserialize_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(68, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add node";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(159, 44);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(85, 23);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(159, 75);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown.TabIndex = 9;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 314);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Deserialize);
            this.Controls.Add(this.txtBox_serializedText);
            this.Controls.Add(this.treeViewBinaryTree);
            this.Controls.Add(this.btn_Serialize);
            this.Name = "Form1";
            this.Text = "Serialize and Deserialize Binary Tree";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Serialize;
        private System.Windows.Forms.TreeView treeViewBinaryTree;
        private System.Windows.Forms.TextBox txtBox_serializedText;
        private System.Windows.Forms.Button btn_Deserialize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

