public class Voo
{
    public DateOnly datavoo;
    public TimeOnly horavoo;
    public int n_voo;


    public bool[] cadeiras;
    public int qtdVagas;

    public Voo(int qtdVagas, DateOnly datVoo, int nVoo)
    {
        // comando (this.) --> utilizado para referenciar que a variável que utilizarei é de fora
        // do construtor
        this.datavoo = datVoo;
        n_voo = nVoo;

        cadeiras = new bool[qtdVagas];
        this.qtdVagas = qtdVagas;
    }

    public int ProxPoltrona()
    {
        for (int i = 0; i < cadeiras.Length; i++)
        {
            if (cadeiras[i] == false)
            {
                return i+1;
            }
        }
        return -1;
    }

    public bool Verificar(int poltrona)
    {
        if (cadeiras[poltrona - 1] == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Ocupa(int poltrona)
    {
        if (this.Verificar(poltrona) == false)
        {
            cadeiras[poltrona - 1] = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int PoltronasLivre(int poltrona = 0)
    {
        for (int i = 0; i < cadeiras.Length; i++)
        {
            if (cadeiras[i] == false)
            {
                poltrona = +1;
            }
        }
        return poltrona;
    }
}