public class Rectangle{
    public int SideA {get;}
    public int SideB {get;}
    
    public Rectangle (int sideA, int sideB){
        SideA = sideA;
        SideB = sideB;
    }
    
    public long GetArea(){
        return SideA * SideB;
    }

    public static int GetNumberOfAngle () => 4;
}