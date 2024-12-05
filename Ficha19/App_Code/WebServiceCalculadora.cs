using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebServiceCalculadora : System.Web.Services.WebService
{
    

    public WebServiceCalculadora()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public Operacao Soma(float num1, float num2)
    {
        Operacao op = new Operacao  ();
        op.Num1 = num1;
        op.Num2 = num2;
        op.Resultado = num1 + num2;
        op.Operador = "+";

        return op;

    }

    [WebMethod]
    public Operacao Subtracao(float num1, float num2)
    {
        Operacao op = new Operacao();
        op.Num1 = num1;
        op.Num2 = num2;
        op.Resultado = num1 - num2;
        op.Operador = "-";

        return op;
    }

    [WebMethod]
    public Operacao Multiplicacao(float num1, float num2)
    {
        Operacao op = new Operacao();
        op.Num1 = num1;
        op.Num2 = num2;
        op.Resultado = num1 * num2;
        op.Operador = "x";

        return op;
    }

    [WebMethod]
    public Operacao Divisao(float num1, float num2)
    {
        Operacao op = new Operacao();
        op.Num1 = num1;
        op.Num2 = num2;
        op.Resultado = num1 / num2;
        op.Operador = "/";

        return op;
    }

}
