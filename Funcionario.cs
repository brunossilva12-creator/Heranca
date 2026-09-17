class Funcionario
{
    public string NomeFuncionario { get; set; }
    public double Salario { get; set; }

    public virtual double CalcularBonusAnual()
    {
        return Salario * 0.10;
    }
}
