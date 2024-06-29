namespace Projeto_Web_lH_Pets_versão_1

public class Program
{
    public static void Main(string[] args)
    {
        var builder = webApplication.createWebApplication(args);
        var app = builder.builder();

        app.MapGet("/", () => "Projeto Web - LH Pets versão 1");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        })

        Banco dba=new Banco()
        app.MapGet ("/listaClientes", (HttpContext contexto) => {

            contexto.Response.WriteAsync( dba.GetListaString());

        });


        app.run();
    }



}