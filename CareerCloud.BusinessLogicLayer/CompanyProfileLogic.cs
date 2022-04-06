using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repo) : base(repo)
        {

        }
        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);

        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> errors = new List<ValidationException>();
            foreach (CompanyProfilePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    errors.Add(new ValidationException(600, "Company Website cannot be empty."));
                }

                else if (!Regex.IsMatch(poco.CompanyWebsite, @"\A(?:(http)?s?:\/\/)?(www.)?([a-z0-9!]+\-?[a-z0-9!]+)+\.(ca|biz|com)\Z", RegexOptions.IgnoreCase))
                {                   
                    errors.Add(new ValidationException(600,
                        "Company Website is not a valid website address format."));
                }

                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    errors.Add(new ValidationException(601, $"Contact Phone Number is required"));
                }
                else
                {
                    string[] phoneDigits = poco.ContactPhone.Split('-');
                    if(phoneDigits[0].Length != 3)
                    {
                        errors.Add(new ValidationException(601, "Enter valid Contact Phone Number"));
                    }
                    else if (phoneDigits[1].Length != 3)
                    {
                        errors.Add(new ValidationException(601, "Enter valid Contact Phone Number"));
                    }
                    else if (phoneDigits[1].Length != 4)
                    {
                        errors.Add(new ValidationException(601, "Enter valid Contact Phone Number"));
                    }

                }

                if (errors.Count > 0)
                {
                    throw new AggregateException(errors);
                }

            }
        }
    }
}
