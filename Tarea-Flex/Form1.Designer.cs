namespace Tarea_Flex
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.colToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSintaxis = new System.Windows.Forms.Label();
            this.lblSemantica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(247, 30);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigo.Size = new System.Drawing.Size(305, 153);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(329, 189);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(115, 39);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // dgvTokens
            // 
            this.dgvTokens.AllowUserToAddRows = false;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colToken,
            this.colLexema});
            this.dgvTokens.Location = new System.Drawing.Point(252, 324);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.ReadOnly = true;
            this.dgvTokens.RowHeadersWidth = 51;
            this.dgvTokens.RowTemplate.Height = 29;
            this.dgvTokens.Size = new System.Drawing.Size(296, 120);
            this.dgvTokens.TabIndex = 2;
            // 
            // colToken
            // 
            this.colToken.HeaderText = "Token";
            this.colToken.MinimumWidth = 6;
            this.colToken.Name = "colToken";
            this.colToken.ReadOnly = true;
            this.colToken.Width = 125;
            // 
            // colLexema
            // 
            this.colLexema.HeaderText = "Lexema";
            this.colLexema.MinimumWidth = 6;
            this.colLexema.Name = "colLexema";
            this.colLexema.ReadOnly = true;
            this.colLexema.Width = 125;
            // 
            // lblSintaxis
            // 
            this.lblSintaxis.AutoSize = true;
            this.lblSintaxis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSintaxis.Location = new System.Drawing.Point(251, 231);
            this.lblSintaxis.Name = "lblSintaxis";
            this.lblSintaxis.Size = new System.Drawing.Size(301, 41);
            this.lblSintaxis.TabIndex = 3;
            this.lblSintaxis.Text = "Resultado sintáctico";
            this.lblSintaxis.Click += new System.EventHandler(this.lblSintaxis_Click);
            // 
            // lblSemantica
            // 
            this.lblSemantica.AutoSize = true;
            this.lblSemantica.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSemantica.Location = new System.Drawing.Point(251, 277);
            this.lblSemantica.Name = "lblSemantica";
            this.lblSemantica.Size = new System.Drawing.Size(309, 41);
            this.lblSemantica.TabIndex = 4;
            this.lblSemantica.Text = "Resultado semántico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSemantica);
            this.Controls.Add(this.lblSintaxis);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCodigo;
        private Button btnAnalizar;
        private DataGridView dgvTokens;
        private DataGridViewTextBoxColumn colToken;
        private DataGridViewTextBoxColumn colLexema;
        private Label lblSintaxis;
        private Label lblSemantica;
    }
}