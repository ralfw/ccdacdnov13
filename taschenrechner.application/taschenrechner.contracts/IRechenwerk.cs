namespace taschenrechner.contracts
{
    public interface IRechenwerk
    {
        int Hier_Ziffer(Ziffern ziffer);
        int Hier_Operator(Operatoren op);
    }

    public enum Ziffern
    {
        @null,
        eins,
        zwei,
        drei,
        vier,
        fünf,
        sechs,
        sieben,
        acht,
        neun
    }

    public enum Operatoren
    {
        plus,
        minus,
        mal,
        geteilt,
        gleich
    }
}