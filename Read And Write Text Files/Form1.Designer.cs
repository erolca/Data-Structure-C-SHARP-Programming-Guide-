namespace Read_And_Write_Text_Files
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonBinaryWriter = new System.Windows.Forms.Button();
            this.buttonBinaryReader = new System.Windows.Forms.Button();
            this.buttonMemoryStream = new System.Windows.Forms.Button();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.buttonStreamReader = new System.Windows.Forms.Button();
            this.buttonTextWriter = new System.Windows.Forms.Button();
            this.buttonTextReader = new System.Windows.Forms.Button();
            this.buttonStringWriter = new System.Windows.Forms.Button();
            this.buttonStringReader = new System.Windows.Forms.Button();
            this.buttonUnmanagedMemoryStream = new System.Windows.Forms.Button();
            this.buttonCompress = new System.Windows.Forms.Button();
            this.buttonDecompress = new System.Windows.Forms.Button();
            this.buttonIsolatedStorage = new System.Windows.Forms.Button();
            this.buttonPorts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Black;
            this.labelHeader.Location = new System.Drawing.Point(8, 8);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(552, 56);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Developed By Gehan Fernando. This Application Target For The Basic .net Developer" +
                "s.";
            // 
            // buttonBinaryWriter
            // 
            this.buttonBinaryWriter.Location = new System.Drawing.Point(8, 72);
            this.buttonBinaryWriter.Name = "buttonBinaryWriter";
            this.buttonBinaryWriter.Size = new System.Drawing.Size(104, 48);
            this.buttonBinaryWriter.TabIndex = 1;
            this.buttonBinaryWriter.Text = "Binary Writer";
            this.buttonBinaryWriter.UseVisualStyleBackColor = true;
            this.buttonBinaryWriter.Click += new System.EventHandler(this.buttonBinaryWriter_Click);
            // 
            // buttonBinaryReader
            // 
            this.buttonBinaryReader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinaryReader.Location = new System.Drawing.Point(120, 72);
            this.buttonBinaryReader.Name = "buttonBinaryReader";
            this.buttonBinaryReader.Size = new System.Drawing.Size(104, 48);
            this.buttonBinaryReader.TabIndex = 2;
            this.buttonBinaryReader.Text = "Binary Reader";
            this.buttonBinaryReader.UseVisualStyleBackColor = true;
            this.buttonBinaryReader.Click += new System.EventHandler(this.buttonBinaryReader_Click);
            // 
            // buttonMemoryStream
            // 
            this.buttonMemoryStream.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryStream.Location = new System.Drawing.Point(232, 72);
            this.buttonMemoryStream.Name = "buttonMemoryStream";
            this.buttonMemoryStream.Size = new System.Drawing.Size(104, 48);
            this.buttonMemoryStream.TabIndex = 3;
            this.buttonMemoryStream.Text = "Memory Stream";
            this.buttonMemoryStream.UseVisualStyleBackColor = true;
            this.buttonMemoryStream.Click += new System.EventHandler(this.buttonMemoryStream_Click);
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStreamWriter.Location = new System.Drawing.Point(344, 72);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(104, 48);
            this.buttonStreamWriter.TabIndex = 4;
            this.buttonStreamWriter.Text = "Stream Writer";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStreamReader
            // 
            this.buttonStreamReader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStreamReader.Location = new System.Drawing.Point(456, 72);
            this.buttonStreamReader.Name = "buttonStreamReader";
            this.buttonStreamReader.Size = new System.Drawing.Size(104, 48);
            this.buttonStreamReader.TabIndex = 5;
            this.buttonStreamReader.Text = "Stream Reader";
            this.buttonStreamReader.UseVisualStyleBackColor = true;
            this.buttonStreamReader.Click += new System.EventHandler(this.buttonStreamReader_Click);
            // 
            // buttonTextWriter
            // 
            this.buttonTextWriter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTextWriter.Location = new System.Drawing.Point(344, 128);
            this.buttonTextWriter.Name = "buttonTextWriter";
            this.buttonTextWriter.Size = new System.Drawing.Size(104, 48);
            this.buttonTextWriter.TabIndex = 6;
            this.buttonTextWriter.Text = "Text Writer";
            this.buttonTextWriter.UseVisualStyleBackColor = true;
            this.buttonTextWriter.Click += new System.EventHandler(this.buttonTextWriter_Click);
            // 
            // buttonTextReader
            // 
            this.buttonTextReader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTextReader.Location = new System.Drawing.Point(456, 128);
            this.buttonTextReader.Name = "buttonTextReader";
            this.buttonTextReader.Size = new System.Drawing.Size(104, 48);
            this.buttonTextReader.TabIndex = 7;
            this.buttonTextReader.Text = "Text Reader";
            this.buttonTextReader.UseVisualStyleBackColor = true;
            this.buttonTextReader.Click += new System.EventHandler(this.buttonTextReader_Click);
            // 
            // buttonStringWriter
            // 
            this.buttonStringWriter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStringWriter.Location = new System.Drawing.Point(344, 184);
            this.buttonStringWriter.Name = "buttonStringWriter";
            this.buttonStringWriter.Size = new System.Drawing.Size(104, 48);
            this.buttonStringWriter.TabIndex = 8;
            this.buttonStringWriter.Text = "String Writer";
            this.buttonStringWriter.UseVisualStyleBackColor = true;
            this.buttonStringWriter.Click += new System.EventHandler(this.buttonStringWriter_Click);
            // 
            // buttonStringReader
            // 
            this.buttonStringReader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStringReader.Location = new System.Drawing.Point(456, 184);
            this.buttonStringReader.Name = "buttonStringReader";
            this.buttonStringReader.Size = new System.Drawing.Size(104, 48);
            this.buttonStringReader.TabIndex = 9;
            this.buttonStringReader.Text = "String Reader";
            this.buttonStringReader.UseVisualStyleBackColor = true;
            this.buttonStringReader.Click += new System.EventHandler(this.buttonStringReader_Click);
            // 
            // buttonUnmanagedMemoryStream
            // 
            this.buttonUnmanagedMemoryStream.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnmanagedMemoryStream.Location = new System.Drawing.Point(232, 128);
            this.buttonUnmanagedMemoryStream.Name = "buttonUnmanagedMemoryStream";
            this.buttonUnmanagedMemoryStream.Size = new System.Drawing.Size(104, 48);
            this.buttonUnmanagedMemoryStream.TabIndex = 10;
            this.buttonUnmanagedMemoryStream.Text = "Unmanaged Memory Stream";
            this.buttonUnmanagedMemoryStream.UseVisualStyleBackColor = true;
            this.buttonUnmanagedMemoryStream.Click += new System.EventHandler(this.buttonUnmanagedMemoryStream_Click);
            // 
            // buttonCompress
            // 
            this.buttonCompress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompress.Location = new System.Drawing.Point(344, 240);
            this.buttonCompress.Name = "buttonCompress";
            this.buttonCompress.Size = new System.Drawing.Size(104, 48);
            this.buttonCompress.TabIndex = 11;
            this.buttonCompress.Text = "Compress";
            this.buttonCompress.UseVisualStyleBackColor = true;
            this.buttonCompress.Click += new System.EventHandler(this.buttonCompress_Click);
            // 
            // buttonDecompress
            // 
            this.buttonDecompress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecompress.Location = new System.Drawing.Point(456, 240);
            this.buttonDecompress.Name = "buttonDecompress";
            this.buttonDecompress.Size = new System.Drawing.Size(104, 48);
            this.buttonDecompress.TabIndex = 12;
            this.buttonDecompress.Text = "Decompress";
            this.buttonDecompress.UseVisualStyleBackColor = true;
            this.buttonDecompress.Click += new System.EventHandler(this.buttonDecompress_Click);
            // 
            // buttonIsolatedStorage
            // 
            this.buttonIsolatedStorage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIsolatedStorage.Location = new System.Drawing.Point(232, 184);
            this.buttonIsolatedStorage.Name = "buttonIsolatedStorage";
            this.buttonIsolatedStorage.Size = new System.Drawing.Size(104, 48);
            this.buttonIsolatedStorage.TabIndex = 13;
            this.buttonIsolatedStorage.Text = "IsolatedStorage";
            this.buttonIsolatedStorage.UseVisualStyleBackColor = true;
            this.buttonIsolatedStorage.Click += new System.EventHandler(this.buttonIsolatedStorage_Click);
            // 
            // buttonPorts
            // 
            this.buttonPorts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPorts.Location = new System.Drawing.Point(232, 240);
            this.buttonPorts.Name = "buttonPorts";
            this.buttonPorts.Size = new System.Drawing.Size(104, 48);
            this.buttonPorts.TabIndex = 14;
            this.buttonPorts.Text = "Ports";
            this.buttonPorts.UseVisualStyleBackColor = true;
            this.buttonPorts.Click += new System.EventHandler(this.buttonPorts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 360);
            this.Controls.Add(this.buttonPorts);
            this.Controls.Add(this.buttonIsolatedStorage);
            this.Controls.Add(this.buttonDecompress);
            this.Controls.Add(this.buttonCompress);
            this.Controls.Add(this.buttonUnmanagedMemoryStream);
            this.Controls.Add(this.buttonStringReader);
            this.Controls.Add(this.buttonStringWriter);
            this.Controls.Add(this.buttonTextReader);
            this.Controls.Add(this.buttonTextWriter);
            this.Controls.Add(this.buttonStreamReader);
            this.Controls.Add(this.buttonStreamWriter);
            this.Controls.Add(this.buttonMemoryStream);
            this.Controls.Add(this.buttonBinaryReader);
            this.Controls.Add(this.buttonBinaryWriter);
            this.Controls.Add(this.labelHeader);
            this.Name = "Form1";
            this.Text = "Use System.IO Namespace ..... With More Fuctions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonBinaryWriter;
        private System.Windows.Forms.Button buttonBinaryReader;
        private System.Windows.Forms.Button buttonMemoryStream;
        private System.Windows.Forms.Button buttonStreamWriter;
        private System.Windows.Forms.Button buttonStreamReader;
        private System.Windows.Forms.Button buttonTextWriter;
        private System.Windows.Forms.Button buttonTextReader;
        private System.Windows.Forms.Button buttonStringWriter;
        private System.Windows.Forms.Button buttonStringReader;
        private System.Windows.Forms.Button buttonUnmanagedMemoryStream;
        private System.Windows.Forms.Button buttonCompress;
        private System.Windows.Forms.Button buttonDecompress;
        private System.Windows.Forms.Button buttonIsolatedStorage;
        private System.Windows.Forms.Button buttonPorts;
    }
}

