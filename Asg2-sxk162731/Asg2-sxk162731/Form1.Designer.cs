namespace Asg2_sxk162731
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataList = new System.Windows.Forms.ListView();
            this.Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phonenumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.proofOfPurchase = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address2 = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 562F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataList, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(28, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1001, 787);
            this.tableLayoutPanel3.TabIndex = 33;
            this.tableLayoutPanel3.UseWaitCursor = true;
            // 
            // dataList
            // 
            this.dataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Firstname,
            this.Phonenumber});
            this.dataList.FullRowSelect = true;
            this.dataList.GridLines = true;
            this.dataList.Location = new System.Drawing.Point(3, 4);
            this.dataList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataList.MinimumSize = new System.Drawing.Size(337, 4);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ShowItemToolTips = true;
            this.dataList.Size = new System.Drawing.Size(433, 779);
            this.dataList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.dataList.TabIndex = 0;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.UseWaitCursor = true;
            this.dataList.View = System.Windows.Forms.View.Details;
            this.dataList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.dataList.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.dataList.Leave += new System.EventHandler(this.listView1_Leave);
            this.dataList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Firstname
            // 
            this.Firstname.Text = "First name";
            this.Firstname.Width = 156;
            // 
            // Phonenumber
            // 
            this.Phonenumber.Text = "Phone number";
            this.Phonenumber.Width = 211;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.fName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.mName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.date, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.proofOfPurchase, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.email, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.phone, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.zipCode, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.state, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.city, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.address2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.address1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(442, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 758);
            this.tableLayoutPanel1.TabIndex = 32;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(67, 590);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 46);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.UseWaitCursor = true;
            this.deleteButton.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(172, 4);
            this.fName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fName.MaxLength = 20;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(208, 26);
            this.fName.TabIndex = 17;
            this.fName.UseWaitCursor = true;
            this.fName.TextChanged += new System.EventHandler(this.field_Changed);
            this.fName.Enter += new System.EventHandler(this.firstname_Enter);
            this.fName.Leave += new System.EventHandler(this.field_Changed);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(172, 38);
            this.lName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lName.MaxLength = 20;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(208, 26);
            this.lName.TabIndex = 18;
            this.lName.UseWaitCursor = true;
            this.lName.TextChanged += new System.EventHandler(this.field_Changed);
            this.lName.Leave += new System.EventHandler(this.field_Changed);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 539);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date received";
            this.label13.UseWaitCursor = true;
            // 
            // mName
            // 
            this.mName.Location = new System.Drawing.Point(172, 77);
            this.mName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mName.MaxLength = 1;
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(43, 26);
            this.mName.TabIndex = 19;
            this.mName.UseWaitCursor = true;
            this.mName.TextChanged += new System.EventHandler(this.field_Changed);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Middle initial";
            this.label3.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 436);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Email";
            this.label11.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            this.label2.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 380);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Phone";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "ZipCode";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "State";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "City";
            this.label7.UseWaitCursor = true;
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date.Location = new System.Drawing.Point(172, 537);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.MaxLength = 10;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(137, 26);
            this.date.TabIndex = 28;
            this.date.UseWaitCursor = true;
            this.date.TextChanged += new System.EventHandler(this.field_Changed);
            this.date.Leave += new System.EventHandler(this.field_Changed);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address 2";
            this.label6.UseWaitCursor = true;
            // 
            // proofOfPurchase
            // 
            this.proofOfPurchase.AccessibleName = "clt_proof_of_purchase";
            this.proofOfPurchase.AutoSize = true;
            this.proofOfPurchase.Checked = true;
            this.proofOfPurchase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.proofOfPurchase.Location = new System.Drawing.Point(172, 495);
            this.proofOfPurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proofOfPurchase.Name = "proofOfPurchase";
            this.proofOfPurchase.Size = new System.Drawing.Size(162, 24);
            this.proofOfPurchase.TabIndex = 27;
            this.proofOfPurchase.Text = "Proof of Purchase";
            this.proofOfPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.proofOfPurchase.UseVisualStyleBackColor = true;
            this.proofOfPurchase.UseWaitCursor = true;
            this.proofOfPurchase.TextChanged += new System.EventHandler(this.field_Changed);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(172, 434);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.MaxLength = 60;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(260, 26);
            this.email.TabIndex = 26;
            this.email.UseWaitCursor = true;
            this.email.TextChanged += new System.EventHandler(this.field_Changed);
            this.email.Leave += new System.EventHandler(this.field_Changed);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(172, 378);
            this.phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone.MaxLength = 20;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(204, 26);
            this.phone.TabIndex = 25;
            this.phone.UseWaitCursor = true;
            this.phone.TextChanged += new System.EventHandler(this.field_Changed);
            this.phone.Leave += new System.EventHandler(this.field_Changed);
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(172, 328);
            this.zipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zipCode.MaxLength = 9;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(137, 26);
            this.zipCode.TabIndex = 24;
            this.zipCode.UseWaitCursor = true;
            this.zipCode.TextChanged += new System.EventHandler(this.field_Changed);
            this.zipCode.Leave += new System.EventHandler(this.field_Changed);
            // 
            // state
            // 
            this.state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.state.Location = new System.Drawing.Point(172, 283);
            this.state.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.state.MaxLength = 2;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(40, 26);
            this.state.TabIndex = 23;
            this.state.UseWaitCursor = true;
            this.state.TextChanged += new System.EventHandler(this.field_Changed);
            this.state.Leave += new System.EventHandler(this.field_Changed);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(172, 232);
            this.city.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.city.MaxLength = 25;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(137, 26);
            this.city.TabIndex = 22;
            this.city.UseWaitCursor = true;
            this.city.TextChanged += new System.EventHandler(this.field_Changed);
            this.city.Leave += new System.EventHandler(this.field_Changed);
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(172, 182);
            this.address2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address2.MaxLength = 35;
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(260, 26);
            this.address2.TabIndex = 21;
            this.address2.UseWaitCursor = true;
            this.address2.TextChanged += new System.EventHandler(this.field_Changed);
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(172, 132);
            this.address1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address1.MaxLength = 35;
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(260, 26);
            this.address1.TabIndex = 20;
            this.address1.UseWaitCursor = true;
            this.address1.TextChanged += new System.EventHandler(this.field_Changed);
            this.address1.Leave += new System.EventHandler(this.field_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            this.label1.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(172, 588);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 76);
            this.tableLayoutPanel2.TabIndex = 33;
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 4);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 46);
            this.clearButton.TabIndex = 30;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.UseWaitCursor = true;
            this.clearButton.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(115, 4);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 46);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "Save";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.UseWaitCursor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address 1";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 830);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(897, 611);
            this.Name = "Form1";
            this.Text = "Asg2-sxk162731";
            this.UseWaitCursor = true;
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.ColumnHeader Phonenumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox proofOfPurchase;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

