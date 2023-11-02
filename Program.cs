using ExemplosExceptions.Models;


try {
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch (Exception e)
{
    Console.WriteLine($"Ocorreu uma exceção: {e.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui !!!");
}


//-------- Throw ----------

new ExemploExcecao().Metodo1();