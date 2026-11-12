namespace gui261112;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btn_add.Click += Btn_add_Click;
        btn_del.Click += Btn_del_Click;
        btn_all_del.Click += Btn_all_del_Click;

    }

    private void Btn_all_del_Click(object? sender, EventArgs e)
    {
        listBox1.Items.Clear();
    }

    private void Btn_del_Click(object? sender, EventArgs e)
    {
        listBox1.Items.Remove(listBox1.SelectedItem);
    }

    private void Btn_add_Click(object? sender, EventArgs e)
    {
        listBox1.Items.Add(textBox1.Text);

    }
}
