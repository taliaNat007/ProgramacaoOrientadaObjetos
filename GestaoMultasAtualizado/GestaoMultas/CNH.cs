public class CNH
{
    public string id_cnh;
    public DateOnly data_emissao;
    public DateOnly data_vencimento;
    public string categoria;
    public int pontuacao;
    public int num_cnh;
    private ProprietarioFisico proprietario;


    public void SetProprietatio (ProprietarioFisico proprietario)
    {

    }

    public ProprietarioFisico GetProprietario ()
    {
        return proprietario;
    }
}
