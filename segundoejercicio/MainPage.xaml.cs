using System.Xml.Linq;

namespace segundoejercicio;

//<Summary>
//<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
///Construí un programa que dados los números A y B, escriba el resultado de la siguiente expresión (A+B)^2/2///
///</lastmodificationdescription>
//////<lastmodifierautor>Maycol Barrera</lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int A1 = Convert.ToInt32(num1.Text);
        int B1 = Convert.ToInt32(num2.Text);
        int r = A1 + B1;
        int y = (r * r) / 2;

		resp.Text = "(" + A1 + "+" + B1 + ")" + "^2/2" + " = " + y;
    }
}







