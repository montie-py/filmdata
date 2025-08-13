namespace FilmInventory.UI;

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
        filmTable = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)filmTable).BeginInit();
        SuspendLayout();
        // 
        // filmTable
        // 
        filmTable.ColumnHeadersHeight = 29;
        filmTable.Dock = System.Windows.Forms.DockStyle.Fill;
        filmTable.Location = new System.Drawing.Point(0, 0);
        filmTable.Name = "filmTable";
        filmTable.RowHeadersWidth = 51;
        filmTable.Size = new System.Drawing.Size(800, 450);
        filmTable.TabIndex = 0;
        filmTable.AutoGenerateColumns = false;
        
        var idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn
        {
            Name = "id",
            HeaderText = "ID",
            Width = 50
        };

        var filmBrandColumn = new DataGridViewTextBoxColumn
        {
            Name = "filmName",
            HeaderText = "Film Brand",
            Width = 150,
            ReadOnly = true,
            Resizable = System.Windows.Forms.DataGridViewTriState.False
        };
        
        var isoColumn = new DataGridViewTextBoxColumn
        {
            Name = "iso",
            HeaderText = "ISO",
            Width = 50,
            ReadOnly = true,
            Resizable = System.Windows.Forms.DataGridViewTriState.False
        };

        var dateColumn = new DataGridViewTextBoxColumn
        {
            Name = "date",
            HeaderText = "Date",
            Width = 150,
            ReadOnly = true,
            Resizable = System.Windows.Forms.DataGridViewTriState.False
        };
        
        filmTable.Columns.AddRange(
            idColumn, 
            filmBrandColumn, 
            isoColumn,
            dateColumn
            );
        
        filmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(filmTable);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "Film Data";
        ((System.ComponentModel.ISupportInitialize)filmTable).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView filmTable;

    #endregion
}