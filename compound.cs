class Compound{
    protected string chemical_name;
    protected float boiling_point;
    protected string molecular_formula;
    public Compound(string chemicalName){
        this.chemical_name = chemicalName;
    }
    public virtual void Display(){
        Console.WriteLine( "chemical name : \t{0} ",chemical_name.ToUpper());
        Console.WriteLine( "-----------------------------------------------");
    }

}