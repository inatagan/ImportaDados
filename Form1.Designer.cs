namespace ImportaDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnImportaDados = new System.Windows.Forms.Button();
            this.btnListaDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(42, 209);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(615, 201);
            this.dgvDados.TabIndex = 0;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(51, 29);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "Diretório";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnImportaDados
            // 
            this.btnImportaDados.Enabled = false;
            this.btnImportaDados.Location = new System.Drawing.Point(51, 70);
            this.btnImportaDados.Name = "btnImportaDados";
            this.btnImportaDados.Size = new System.Drawing.Size(75, 23);
            this.btnImportaDados.TabIndex = 2;
            this.btnImportaDados.Text = "Importar Dados";
            this.btnImportaDados.UseVisualStyleBackColor = true;
            this.btnImportaDados.Click += new System.EventHandler(this.btnImportaDados_Click);
            // 
            // btnListaDados
            // 
            this.btnListaDados.Location = new System.Drawing.Point(51, 114);
            this.btnListaDados.Name = "btnListaDados";
            this.btnListaDados.Size = new System.Drawing.Size(75, 23);
            this.btnListaDados.TabIndex = 3;
            this.btnListaDados.Text = "Listar Dados";
            this.btnListaDados.UseVisualStyleBackColor = true;
            this.btnListaDados.Click += new System.EventHandler(this.btnListaDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.btnListaDados);
            this.Controls.Add(this.btnImportaDados);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.dgvDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnImportaDados;
        private System.Windows.Forms.Button btnListaDados;
    }
}

