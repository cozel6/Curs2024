namespace ExercituIepure
{
    public enum EyeColor
    {
        Blue,
        Red,
        Black
    }
    public enum FurColor
    {
        White,
        Brown,
        Black
    }
    public enum Gender
    {
        Male,
        Female
    }

    internal class Iepurele
    {

        public Iepurele(EyeColor eyeColor, FurColor furColor, Gender gender, DateTime birthDate)
        {
            EyeColor = eyeColor;
            FurColor = furColor;
            Gender = gender;
            BirthDate = birthDate;
        }

        public EyeColor EyeColor { get;}
        public FurColor FurColor { get;}
        public Gender Gender { get;}
        public DateTime BirthDate { get;}


        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthDate.Year;
            if (currentDate.Year < BirthDate.Year)
            {
                age--;
            }
            return age;
        }
    }
}
