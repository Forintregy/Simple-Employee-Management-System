namespace EmployeeManagerModel
{
    public partial class Address
    {
        public override string ToString()
        {
            return $"{City}, ул. {StreetAddress}, кв. {Apartment}";
        }

        public string GetFullAddress()
        {
            return $"{ZipCode}, {Country}, {Region}, {City}, {StreetAddress}, {Apartment}";
        }

        public override bool Equals(object obj)
        {
            if (obj as Address==null) return false;
            var other = (Address) obj;
            bool zipCodesEqual = HelperMethods.CustomStringComparer(this.ZipCode, other.ZipCode); 
            bool citiesEqual = HelperMethods.CustomStringComparer(this.City, other.City); 
            bool countriesEqual = HelperMethods.CustomStringComparer(this.Country, other.Country); 
            bool regionsEqual = HelperMethods.CustomStringComparer(this.Region, other.Region); 
            bool streetAdressesEqual = HelperMethods.CustomStringComparer(this.StreetAddress, other.StreetAddress); 
            bool apartmentsEqual = HelperMethods.CustomStringComparer(this.Apartment, other.Apartment);

            return  zipCodesEqual && citiesEqual && countriesEqual && 
                    regionsEqual && streetAdressesEqual && apartmentsEqual;    
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
