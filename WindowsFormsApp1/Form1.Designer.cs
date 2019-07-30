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
            this.SuspendLayout();
            // 
            // btn_Serialize
            // 
            this.btn_Serialize.Location = new System.Drawing.Point(282, 98);
            this.btn_Serialize.Name = "btn_Serialize";
            this.btn_Serialize.Size = new System.Drawing.Size(97, 23);
            this.btn_Serialize.TabIndex = 0;
            this.btn_Serialize.Text = ">> Serialize >>";
            this.btn_Serialize.UseVisualStyleBackColor = true;
            this.btn_Serialize.Click += new System.EventHandler(this.btn_Serialize_Click);
            // 
            // treeViewBinaryTree
            // 
            this.treeViewBinaryTree.Location = new System.Drawing.Point(68, 77);
            this.treeViewBinaryTree.Name = "treeViewBinaryTree";
            this.treeViewBinaryTree.Size = new System.Drawing.Size(181, 158);
            this.treeViewBinaryTree.TabIndex = 2;
            // 
            // txtBox_serializedText
            // 
            this.txtBox_serializedText.Location = new System.Drawing.Point(412, 134);
            this.txtBox_serializedText.Name = "txtBox_serializedText";
            this.txtBox_serializedText.Size = new System.Drawing.Size(171, 20);
            this.txtBox_serializedText.TabIndex = 3;
            this.txtBox_serializedText.Text = "[1,2,3,null,null,4,5]";
            // 
            // btn_Deserialize
            // 
            this.btn_Deserialize.Location = new System.Drawing.Point(282, 156);
            this.btn_Deserialize.Name = "btn_Deserialize";
            this.btn_Deserialize.Size = new System.Drawing.Size(97, 23);
            this.btn_Deserialize.TabIndex = 4;
            this.btn_Deserialize.Text = "<< Deserialize <<";
            this.btn_Deserialize.UseVisualStyleBackColor = true;
            this.btn_Deserialize.Click += new System.EventHandler(this.btn_Deserialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 314);
            this.Controls.Add(this.btn_Deserialize);
            this.Controls.Add(this.txtBox_serializedText);
            this.Controls.Add(this.treeViewBinaryTree);
            this.Controls.Add(this.btn_Serialize);
            this.Name = "Form1";
            this.Text = "Serialize and Deserialize Binary Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Serialize;
        private System.Windows.Forms.TreeView treeViewBinaryTree;
        private System.Windows.Forms.TextBox txtBox_serializedText;
        private System.Windows.Forms.Button btn_Deserialize;
    }
}

