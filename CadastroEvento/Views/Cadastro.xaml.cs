namespace CadastroEvento.Views;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = DateTime.Now.AddMonths(6);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(1);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Resumo());
		}
		catch (Exception ex)
		{
			DisplayAlert("OPS", ex.Message, "OK");
		}
    }
}