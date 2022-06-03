// See https://aka.ms/new-console-template for more information
using System.IO;


Console.WriteLine("Digite o nome do arquivo");
var nome = Console.ReadLine();
nome = LimparNome(nome);


var path =Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

///File.Create(parth);

CriarArquivo(path);
//CriarDiretorioGlobo();
//LerDiretorio(@"c:\temp\globo");

Console.WriteLine("Digite enter para finalizar....");
Console.ReadLine();

static string LimparNome(string nome){
        foreach (var @char in Path.GetInvalidFileNameChars())
        {
            nome= nome.Replace(@char,'-');
        }
        return nome;
}

//File.Copy
//File.Move

static void CriarArquivo(string path){

    try
    {
    if (!File.Exists(path)){
         using (var sw = File.CreateText(path)){
            sw.WriteLine("Line 01");
            sw.WriteLine("Line 02");
            sw.WriteLine("Line 03");
        }
    }
 
    }
    catch (System.Exception)
    {
        
        Console.WriteLine("Arquivo inválido");
    }
  


}

static void CriarDiretorioGlobo(){
    var path =Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path)){
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("America do norte");
        var dirAmSul = dirGlobo.CreateSubdirectory("America do sul");

        dirAmNorte.CreateSubdirectory("Usa");
        dirAmCentral.CreateSubdirectory("Mexico");
        dirAmSul.CreateSubdirectory("Panama");
    }

}

static void MoverArquivo(string pathOrigem, string destino){
    File.Move(pathOrigem, destino);

}

static void LerDiretorio(string path){

    if (!Directory.Exists(path)){
        var diretorios = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);

        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
           Console.WriteLine($"[Nome]: {dirInfo.Name}");
           Console.WriteLine($"[Raíz]: {dirInfo.Root}");

          if (dirInfo.Parent != null )
          Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");
         }
    } else{
        Console.WriteLine("não existe");
    }
    
}






