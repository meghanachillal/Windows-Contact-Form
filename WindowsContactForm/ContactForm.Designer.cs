//  File ContactForm
// 
// Assignment #2
// Due TBD
//
// Requirement 1: Expand on this form to display information in database that displays the following fields
// First Name (TextBox)
// Last Name (TextBox)
// Street Number (TextBox)
// City (TextBox) 
// Province (TextBox)
// Country (TextBox)
// Postal Code  (TextBox)
// Phone Number (TextBox)
// email Address (TextBox)
//
// Add Next and Prevous Buttons to navigate through the database ( handle index 0 and max index)
// Display the current primary key of the database in a textbox or label
// Add a Status TextBox and dispaly any formatting errors that are encoutered, 
// If multiple errors exist only show last one.

// Requirement 2: Expand on the below example to create a import the contents of the CSV file 
// created in Assignment1, read the data into entity classes and save data to database.  
// After import Next and Prev buttons should work.
//
// TODO for Dan - add example of how to save data
//
// Please always try to write clean And readable code
// Here Is a good reference doc http://ricardogeek.com/docs/clean_code.html  
// Submit to Bitbucket under Assignment2

namespace WindowsContactForm
{
    partial class ContactForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelStreetNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textImportFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxlastName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(105, 34);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(158, 34);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(180, 26);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(158, 75);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(180, 26);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(54, 78);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(332, 418);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(112, 35);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(511, 418);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(112, 35);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButtonClick);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(602, 75);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.Location = new System.Drawing.Point(158, 124);
            this.textBoxStreetNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(180, 26);
            this.textBoxStreetNumber.TabIndex = 8;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(158, 248);
            this.textBoxProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(180, 26);
            this.textBoxProvince.TabIndex = 10;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(158, 296);
            this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(180, 26);
            this.textBoxPostalCode.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(158, 345);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(335, 26);
            this.textBoxEmail.TabIndex = 14;
            // 
            // labelStreetNumber
            // 
            this.labelStreetNumber.AutoSize = true;
            this.labelStreetNumber.Location = new System.Drawing.Point(27, 124);
            this.labelStreetNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStreetNumber.Name = "labelStreetNumber";
            this.labelStreetNumber.Size = new System.Drawing.Size(113, 20);
            this.labelStreetNumber.TabIndex = 15;
            this.labelStreetNumber.Text = "Street Number";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(653, 130);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 16;
            this.labelCity.Text = "City";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(62, 248);
            this.labelProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(69, 20);
            this.labelProvince.TabIndex = 17;
            this.labelProvince.Text = "Province";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(624, 186);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(64, 20);
            this.labelCountry.TabIndex = 18;
            this.labelCountry.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Postal Code";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(575, 245);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.labelPhoneNumber.TabIndex = 20;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(83, 348);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(628, 293);
            this.labelstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelstatus.Size = new System.Drawing.Size(56, 20);
            this.labelstatus.TabIndex = 22;
            this.labelstatus.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStatus.Location = new System.Drawing.Point(715, 293);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(180, 78);
            this.textBoxStatus.TabIndex = 23;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 509);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 20);
            this.label.TabIndex = 24;
            this.label.Text = "Import CSV file";
            // 
            // textImportFile
            // 
            this.textImportFile.Location = new System.Drawing.Point(158, 506);
            this.textImportFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textImportFile.Name = "textImportFile";
            this.textImportFile.Size = new System.Drawing.Size(335, 26);
            this.textImportFile.TabIndex = 25;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(541, 501);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(115, 37);
            this.buttonBrowse.TabIndex = 26;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(332, 554);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(112, 35);
            this.buttonImport.TabIndex = 27;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(158, 160);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(180, 78);
            this.textBoxAddress.TabIndex = 28;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(62, 163);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 29;
            this.labelAddress.Text = "Address";
            // 
            // textBoxlastName
            // 
            this.textBoxlastName.Location = new System.Drawing.Point(715, 75);
            this.textBoxlastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxlastName.Name = "textBoxlastName";
            this.textBoxlastName.Size = new System.Drawing.Size(180, 26);
            this.textBoxlastName.TabIndex = 30;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(715, 124);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(180, 26);
            this.textBoxCity.TabIndex = 31;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(715, 180);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(180, 26);
            this.textBoxCountry.TabIndex = 32;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(715, 239);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(180, 26);
            this.textBoxPhoneNumber.TabIndex = 33;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 617);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxlastName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textImportFile);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreetNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxStreetNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactForm";
            this.Text = "CONTACT FORM";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelStreetNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textImportFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxlastName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}

