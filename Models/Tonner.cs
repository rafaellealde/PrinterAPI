public class Tonner
{
    public int Id { get; set; }
    public string? Printer { get; set; }
    public string? Tipo { get; set; }
    public string? Cor { get; set; }
    public string SelbValue { get; set; } = string.Empty;// coloquei a string inves da
    //colecao
    public int QuantidadeDeTonner { get; set; } //adicionei que estava faltando

    //adicionei um construtor
    public Tonner(int id, string? printer, string? tipo, string? cor, string selbValue, int quantidadeDeTonner)
    {
        Id = id;
        Printer = printer;
        Tipo = tipo;
        Cor = cor;
        SelbValue = selbValue;
        QuantidadeDeTonner = quantidadeDeTonner;
    }
}