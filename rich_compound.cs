class RichCompound :Compound {
    private ChemicalBank _bank = new ChemicalBank();
    public RichCompound(string chemicalName):base(chemicalName){

    }
    public override void Display(){
        boiling_point= _bank.getBoilingPoint(chemical_name);
        molecular_formula = _bank.getMolecularFormula(chemical_name);
        base.Display();
        Console.WriteLine("Boiling Point : \t{0}",boiling_point);
        Console.WriteLine("Molecular Formula : \t{0}",molecular_formula);
        Console.WriteLine();
    }

}