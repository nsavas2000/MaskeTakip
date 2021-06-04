using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient clint = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return clint.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TcKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
