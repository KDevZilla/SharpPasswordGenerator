using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class PasswordProperties
    {

        public int PasswordLength { get; set; }

        public Boolean IsIncludeSymbol { get; set; }
        public Boolean IsIncludeNumber { get; set; }
        public Boolean IsIncludeLowerCase { get; set; }
        public Boolean IsIncludeUpperCase { get; set; }
        public Boolean IsExcludeSimilarCharacter { get; set; }
        public Boolean IsExcludeAmbigousCharacter { get; set; }
        public Boolean IsExcludeCompromisePassword { get; set; }
        public enum enCase
        {
            IsIncludeSymbol,
            IsIncludeNumber,
            IsIncludeLowerCase,
            IsIncludeUpperCase
        }
        private void LoadDicRule()
        {
            _DicRule = new Dictionary<enCase, bool>();

        }
        private Dictionary<enCase, Boolean> _DicRule = null;
        public Dictionary<enCase, Boolean> DicRule
        {
            get
            {
                if (_DicRule == null)
                {
                    LoadDicRule();
                }
                return _DicRule;
            }
            set
            {
                _DicRule = value;
                //this.DicRule[enCase.IsIncludeLowerCase] = true;

            }


        }

        public MethodResult<Boolean> IsMatch(PasswordProperties Rule)
        {
            MethodResult<Boolean> Result = new MethodResult<bool>(false);

            if (this.IsIncludeLowerCase != Rule.IsIncludeLowerCase)
            {
                Result.ErrorMessage = " Password lower case does not match with Rule";
                return Result;

            }
            if (this.IsIncludeUpperCase != Rule.IsIncludeUpperCase)
            {
                Result.ErrorMessage = " Password Upper case does not match with Rule";
                return Result;
            }
            if (this.IsIncludeNumber != Rule.IsIncludeNumber)
            {
                Result.ErrorMessage = " Password Number case does not match with Rule";
                return Result;
            }

            if (this.IsIncludeSymbol != Rule.IsIncludeSymbol)
            {
                Result.ErrorMessage = " Password Symbol case does not match with Rule";
                return Result;
            }

            if (this.PasswordLength != Rule.PasswordLength)
            {
                Result.ErrorMessage = " Password Length is not match with Rule";
                return Result;
            }


            if (this.IsExcludeCompromisePassword != Rule.IsExcludeCompromisePassword)
            {
                Result.ErrorMessage = " Password Exclude Compromise password is not match with Rule";
                return Result;
            }
            Result.ErrorMessage = "";
            Result.Result = true;
            return Result;

        }

        public static PasswordProperties Build()
        {
            PasswordProperties p = new PasswordProperties();
            p.IsIncludeLowerCase = false;
            p.IsIncludeNumber = false;
            p.IsIncludeSymbol = false;
            p.IsIncludeUpperCase = false;
            return p;
        }
        public PasswordProperties Length(int pLength)
        {
            this.PasswordLength = pLength;
            return this;
        }

        public PasswordProperties IncludeSymbol(Boolean pIsIncludeSymbol)
        {
            this.IsIncludeSymbol = pIsIncludeSymbol;
            return this;
        }
        public PasswordProperties IncludeNumber(Boolean pIsIncludeNumber)
        {
            this.IsIncludeNumber = pIsIncludeNumber;
            return this;
        }

        public PasswordProperties IncludeLowerCase(Boolean pIsIncludeLowerCase)
        {
            this.IsIncludeLowerCase = pIsIncludeLowerCase;
            return this;
        }

        public PasswordProperties IncludeUpperCase(Boolean pIsIncludeUpperCase)
        {
            this.IsIncludeUpperCase = pIsIncludeUpperCase;
            return this;
        }

        public PasswordProperties ExcludeSimilarCharacter(Boolean pIsExcludeSimilarCharacter)
        {
            this.IsExcludeAmbigousCharacter = pIsExcludeSimilarCharacter;
            return this;
        }

        public PasswordProperties ExcludeAmbigousCharacter(Boolean pIsExcludeSimilarCharacter)
        {
            this.IsExcludeAmbigousCharacter = pIsExcludeSimilarCharacter;
            return this;
        }

        public PasswordProperties ExcludeCompromisePassword(Boolean pIsExcludeCompromisePassword)
        {
            this.IsExcludeCompromisePassword = pIsExcludeCompromisePassword;
            return this;
        }
    }
}
