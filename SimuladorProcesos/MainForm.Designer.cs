namespace SimuladorProcesos
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProcesos = new System.Windows.Forms.DataGridView();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.stripMAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.refernciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.AllowUserToAddRows = false;
            this.dataGridViewProcesos.AllowUserToDeleteRows = false;
            this.dataGridViewProcesos.AllowUserToResizeColumns = false;
            this.dataGridViewProcesos.AllowUserToResizeRows = false;
            this.dataGridViewProcesos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado,
            this.tiempo,
            this.Tipo});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewProcesos.MultiSelect = false;
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.ReadOnly = true;
            this.dataGridViewProcesos.RowHeadersVisible = false;
            this.dataGridViewProcesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcesos.Size = new System.Drawing.Size(413, 390);
            this.dataGridViewProcesos.TabIndex = 0;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.Location = new System.Drawing.Point(40, 442);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(359, 30);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonCorrer_Click);
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMAcerca,
            this.stripMCreditos});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(438, 24);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // stripMAcerca
            // 
            this.stripMAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refernciaToolStripMenuItem,
            this.reseñaToolStripMenuItem});
            this.stripMAcerca.Name = "stripMAcerca";
            this.stripMAcerca.Size = new System.Drawing.Size(72, 20);
            this.stripMAcerca.Text = "Acerda de";
            // 
            // refernciaToolStripMenuItem
            // 
            this.refernciaToolStripMenuItem.Name = "refernciaToolStripMenuItem";
            this.refernciaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.refernciaToolStripMenuItem.Text = "Referncia";
            this.refernciaToolStripMenuItem.Click += new System.EventHandler(this.refernciaToolStripMenuItem_Click);
            // 
            // reseñaToolStripMenuItem
            // 
            this.reseñaToolStripMenuItem.Name = "reseñaToolStripMenuItem";
            this.reseñaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.reseñaToolStripMenuItem.Text = "Reseña";
            this.reseñaToolStripMenuItem.Click += new System.EventHandler(this.reseñaToolStripMenuItem_Click);
            // 
            // stripMCreditos
            // 
            this.stripMCreditos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem});
            this.stripMCreditos.Name = "stripMCreditos";
            this.stripMCreditos.Size = new System.Drawing.Size(63, 20);
            this.stripMCreditos.Text = "Creditos";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 484);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dataGridViewProcesos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Lector - Escritor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem stripMAcerca;
        private System.Windows.Forms.ToolStripMenuItem refernciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMCreditos;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

