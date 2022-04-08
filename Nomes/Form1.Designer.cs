namespace Nomes
{
    partial class Nomes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomes));
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbconta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAtualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAppagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Adicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Azure;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGrid.Location = new System.Drawing.Point(94, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.Size = new System.Drawing.Size(423, 299);
            this.dataGrid.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "TOTAL:";
            // 
            // lbconta
            // 
            this.lbconta.AutoSize = true;
            this.lbconta.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconta.Location = new System.Drawing.Point(9, 42);
            this.lbconta.Name = "lbconta";
            this.lbconta.Size = new System.Drawing.Size(0, 19);
            this.lbconta.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BackgroundImage = global::Nomes.Properties.Resources.icons8_control_panel_64px;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnAppagar);
            this.panel1.Controls.Add(this.Adicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 83);
            this.panel1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Info;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID.HintForeColor = System.Drawing.Color.Empty;
            this.ID.HintText = "ID";
            this.ID.isPassword = false;
            this.ID.LineFocusedColor = System.Drawing.Color.Lavender;
            this.ID.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.ID.LineMouseHoverColor = System.Drawing.Color.GhostWhite;
            this.ID.LineThickness = 3;
            this.ID.Location = new System.Drawing.Point(397, 4);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(115, 33);
            this.ID.TabIndex = 2;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HintForeColor = System.Drawing.Color.Empty;
            this.txtNome.HintText = "Nome";
            this.txtNome.isPassword = false;
            this.txtNome.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNome.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.txtNome.LineMouseHoverColor = System.Drawing.Color.GhostWhite;
            this.txtNome.LineThickness = 3;
            this.txtNome.Location = new System.Drawing.Point(15, 4);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 33);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ActiveBorderThickness = 1;
            this.btnAtualizar.ActiveCornerRadius = 20;
            this.btnAtualizar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAtualizar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAtualizar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAtualizar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnAtualizar.BackColor = System.Drawing.Color.Azure;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.ButtonText = "Atualizar";
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.IdleBorderThickness = 1;
            this.btnAtualizar.IdleCornerRadius = 20;
            this.btnAtualizar.IdleFillColor = System.Drawing.Color.White;
            this.btnAtualizar.IdleForecolor = System.Drawing.Color.MediumAquamarine;
            this.btnAtualizar.IdleLineColor = System.Drawing.Color.Aquamarine;
            this.btnAtualizar.Location = new System.Drawing.Point(213, 44);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(112, 34);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAppagar
            // 
            this.btnAppagar.ActiveBorderThickness = 1;
            this.btnAppagar.ActiveCornerRadius = 20;
            this.btnAppagar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAppagar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAppagar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAppagar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnAppagar.BackColor = System.Drawing.Color.Azure;
            this.btnAppagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppagar.BackgroundImage")));
            this.btnAppagar.ButtonText = "Apagar";
            this.btnAppagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppagar.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppagar.ForeColor = System.Drawing.Color.Black;
            this.btnAppagar.IdleBorderThickness = 1;
            this.btnAppagar.IdleCornerRadius = 20;
            this.btnAppagar.IdleFillColor = System.Drawing.Color.White;
            this.btnAppagar.IdleForecolor = System.Drawing.Color.MediumAquamarine;
            this.btnAppagar.IdleLineColor = System.Drawing.Color.Aquamarine;
            this.btnAppagar.Location = new System.Drawing.Point(398, 46);
            this.btnAppagar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAppagar.Name = "btnAppagar";
            this.btnAppagar.Size = new System.Drawing.Size(112, 34);
            this.btnAppagar.TabIndex = 3;
            this.btnAppagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAppagar.Click += new System.EventHandler(this.btnAppagar_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.ActiveBorderThickness = 1;
            this.Adicionar.ActiveCornerRadius = 20;
            this.Adicionar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Adicionar.ActiveForecolor = System.Drawing.Color.White;
            this.Adicionar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Adicionar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Adicionar.BackColor = System.Drawing.Color.Azure;
            this.Adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Adicionar.BackgroundImage")));
            this.Adicionar.ButtonText = "Adicionar";
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.Color.Black;
            this.Adicionar.IdleBorderThickness = 1;
            this.Adicionar.IdleCornerRadius = 20;
            this.Adicionar.IdleFillColor = System.Drawing.Color.White;
            this.Adicionar.IdleForecolor = System.Drawing.Color.MediumAquamarine;
            this.Adicionar.IdleLineColor = System.Drawing.Color.Aquamarine;
            this.Adicionar.Location = new System.Drawing.Point(17, 46);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(112, 34);
            this.Adicionar.TabIndex = 2;
            this.Adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Nomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(517, 382);
            this.Controls.Add(this.lbconta);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Nomes";
            this.Text = "Nomes";
            this.Load += new System.EventHandler(this.Nomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAtualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAppagar;
        private Bunifu.Framework.UI.BunifuThinButton2 Adicionar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbconta;
    }
}

