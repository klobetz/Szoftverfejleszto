namespace Plane_ENG
{
    // abstract függvényt csak absztract osztályban tudok létrehozni
    public abstract class Plane : IPlane
    {
        //mivel nincs álltalános síkidom terület számítás így nem tudok implementálni ide semmit

        //abstract függvényt tudok létrehozni
        public abstract double Area();

        //Az abstract azt jelent hogy nincs implementáció ezért leszármaztatás közben implementáljuk

        //további kötelmek: 
        //abstract függvényt csak absztract osztályban tudok létrehozni
        //abstract osztálynak lehet nem astract tulajdonsága, mezője....
        //adstract osztályt nem lehet példányosítani azaz csak a töbszörös leszármaztatásnál lehet felhasználni
        //a leszármazttatási hierachiában veszzük hasznát

       
        
        
        //név kiíratásho property
        //ez nem abstract tolajdonság
        public string Name { get; set; }



    }


}