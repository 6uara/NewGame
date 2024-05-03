public class SphereSpawner:AbstractFactory
{
    public override Sphere CreateProduct(PTypes types)
    {
        /*
        switch(types)
        {
            case PTypes.Normal:
                return new Sphere("Normal");
            case PTypes.Big:
                return new Sphere("Big");
            case PTypes.Small:
                return new Sphere("Small");
        }   
        */
        return null;  
    }
}