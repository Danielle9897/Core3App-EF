namespace TestProfilerWithCore3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.buttonSQLConnect = new System.Windows.Forms.Button();
            this.EFbuttonAdd = new System.Windows.Forms.Button();
            this.EFbuttonGetAllBlogs = new System.Windows.Forms.Button();
            this.TextBoxBlogId = new System.Windows.Forms.TextBox();
            this.EFbuttonGetById = new System.Windows.Forms.Button();
            this.EFbuttonUpdate = new System.Windows.Forms.Button();
            this.EFbuttonDelete = new System.Windows.Forms.Button();
            this.EFGetBlogFromPost = new System.Windows.Forms.Button();
            this.EFbuttonGetBlogsCount = new System.Windows.Forms.Button();
            this.EFbuttonAnyQuery = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSQLConnect
            // 
            this.buttonSQLConnect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSQLConnect.Location = new System.Drawing.Point(29, 646);
            this.buttonSQLConnect.Name = "buttonSQLConnect";
            this.buttonSQLConnect.Size = new System.Drawing.Size(196, 40);
            this.buttonSQLConnect.TabIndex = 1;
            this.buttonSQLConnect.Text = "Connect with SqlConnection\r\n";
            this.buttonSQLConnect.UseVisualStyleBackColor = false;
            this.buttonSQLConnect.Click += new System.EventHandler(this.buttonSQLConnect_Click);
            // 
            // EFbuttonAdd
            // 
            this.EFbuttonAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonAdd.Location = new System.Drawing.Point(21, 25);
            this.EFbuttonAdd.Name = "EFbuttonAdd";
            this.EFbuttonAdd.Size = new System.Drawing.Size(376, 40);
            this.EFbuttonAdd.TabIndex = 2;
            this.EFbuttonAdd.Text = "EF - Add new Blog";
            this.EFbuttonAdd.UseVisualStyleBackColor = false;
            this.EFbuttonAdd.Click += new System.EventHandler(this.EFbuttonAdd_Click);
            // 
            // EFbuttonGetAllBlogs
            // 
            this.EFbuttonGetAllBlogs.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonGetAllBlogs.Location = new System.Drawing.Point(21, 117);
            this.EFbuttonGetAllBlogs.Name = "EFbuttonGetAllBlogs";
            this.EFbuttonGetAllBlogs.Size = new System.Drawing.Size(376, 40);
            this.EFbuttonGetAllBlogs.TabIndex = 3;
            this.EFbuttonGetAllBlogs.Text = "EF - Get all Blogs";
            this.EFbuttonGetAllBlogs.UseVisualStyleBackColor = false;
            this.EFbuttonGetAllBlogs.Click += new System.EventHandler(this.EFbuttonGetAllBlogs_Click);
            // 
            // TextBoxBlogId
            // 
            this.TextBoxBlogId.Location = new System.Drawing.Point(350, 108);
            this.TextBoxBlogId.Name = "TextBoxBlogId";
            this.TextBoxBlogId.Size = new System.Drawing.Size(84, 23);
            this.TextBoxBlogId.TabIndex = 5;
            // 
            // EFbuttonGetById
            // 
            this.EFbuttonGetById.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonGetById.Location = new System.Drawing.Point(19, 23);
            this.EFbuttonGetById.Name = "EFbuttonGetById";
            this.EFbuttonGetById.Size = new System.Drawing.Size(296, 40);
            this.EFbuttonGetById.TabIndex = 4;
            this.EFbuttonGetById.Text = "EF - Get Blog by ID\r\n";
            this.EFbuttonGetById.UseVisualStyleBackColor = false;
            this.EFbuttonGetById.Click += new System.EventHandler(this.EFbuttonGetById_Click);
            // 
            // EFbuttonUpdate
            // 
            this.EFbuttonUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonUpdate.Location = new System.Drawing.Point(19, 69);
            this.EFbuttonUpdate.Name = "EFbuttonUpdate";
            this.EFbuttonUpdate.Size = new System.Drawing.Size(296, 40);
            this.EFbuttonUpdate.TabIndex = 4;
            this.EFbuttonUpdate.Text = "EF - Update \'Created At\' column";
            this.EFbuttonUpdate.UseVisualStyleBackColor = false;
            this.EFbuttonUpdate.Click += new System.EventHandler(this.EFbuttonUpdate_Click);
            // 
            // EFbuttonDelete
            // 
            this.EFbuttonDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonDelete.Location = new System.Drawing.Point(19, 115);
            this.EFbuttonDelete.Name = "EFbuttonDelete";
            this.EFbuttonDelete.Size = new System.Drawing.Size(296, 40);
            this.EFbuttonDelete.TabIndex = 6;
            this.EFbuttonDelete.Text = "EF - Delete Blog";
            this.EFbuttonDelete.UseVisualStyleBackColor = false;
            this.EFbuttonDelete.Click += new System.EventHandler(this.EFbuttonDelete_Click);
            // 
            // EFGetBlogFromPost
            // 
            this.EFGetBlogFromPost.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFGetBlogFromPost.Location = new System.Drawing.Point(19, 161);
            this.EFGetBlogFromPost.Name = "EFGetBlogFromPost";
            this.EFGetBlogFromPost.Size = new System.Drawing.Size(296, 40);
            this.EFGetBlogFromPost.TabIndex = 7;
            this.EFGetBlogFromPost.Text = "EF - Get Blog from Post";
            this.EFGetBlogFromPost.UseVisualStyleBackColor = false;
            this.EFGetBlogFromPost.Click += new System.EventHandler(this.EFGetBlogFromPost_Click);
            // 
            // EFbuttonGetBlogsCount
            // 
            this.EFbuttonGetBlogsCount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonGetBlogsCount.Location = new System.Drawing.Point(20, 71);
            this.EFbuttonGetBlogsCount.Name = "EFbuttonGetBlogsCount";
            this.EFbuttonGetBlogsCount.Size = new System.Drawing.Size(376, 40);
            this.EFbuttonGetBlogsCount.TabIndex = 8;
            this.EFbuttonGetBlogsCount.Text = "EF - Get Blogs Count - with raw sql\r\n";
            this.EFbuttonGetBlogsCount.UseVisualStyleBackColor = false;
            this.EFbuttonGetBlogsCount.Click += new System.EventHandler(this.EFbuttonGetBlogsCount_Click);
            // 
            // EFbuttonAnyQuery
            // 
            this.EFbuttonAnyQuery.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EFbuttonAnyQuery.Location = new System.Drawing.Point(20, 32);
            this.EFbuttonAnyQuery.Name = "EFbuttonAnyQuery";
            this.EFbuttonAnyQuery.Size = new System.Drawing.Size(377, 40);
            this.EFbuttonAnyQuery.TabIndex = 9;
            this.EFbuttonAnyQuery.Text = "EF - Raw Query on Blogs Table";
            this.EFbuttonAnyQuery.UseVisualStyleBackColor = false;
            this.EFbuttonAnyQuery.Click += new System.EventHandler(this.EFbuttonAnyQuery_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(21, 79);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(376, 57);
            this.QueryTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (196)))), ((int) (((byte) (196)))),
                ((int) (((byte) (215)))));
            this.panel1.Controls.Add(this.EFbuttonAdd);
            this.panel1.Controls.Add(this.EFbuttonGetAllBlogs);
            this.panel1.Controls.Add(this.EFbuttonGetBlogsCount);
            this.panel1.Location = new System.Drawing.Point(29, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 172);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.EFbuttonGetById);
            this.panel2.Controls.Add(this.EFbuttonUpdate);
            this.panel2.Controls.Add(this.TextBoxBlogId);
            this.panel2.Controls.Add(this.EFbuttonDelete);
            this.panel2.Controls.Add(this.EFGetBlogFromPost);
            this.panel2.Location = new System.Drawing.Point(29, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 217);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(334, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (157)))), ((int) (((byte) (157)))),
                ((int) (((byte) (157)))));
            this.panel3.Controls.Add(this.EFbuttonAnyQuery);
            this.panel3.Controls.Add(this.QueryTextBox);
            this.panel3.Location = new System.Drawing.Point(29, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 174);
            this.panel3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(526, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSQLConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonSQLConnect;
        private System.Windows.Forms.TextBox TextBoxBlogId;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button EFbuttonAdd;
        private System.Windows.Forms.Button EFbuttonGetBlogsCount;
        private System.Windows.Forms.Button EFbuttonGetAllBlogs;
        private System.Windows.Forms.Button EFbuttonGetById;
        private System.Windows.Forms.Button EFbuttonUpdate;
        private System.Windows.Forms.Button EFbuttonDelete;
        private System.Windows.Forms.Button EFGetBlogFromPost;
        private System.Windows.Forms.Button EFbuttonAnyQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}

