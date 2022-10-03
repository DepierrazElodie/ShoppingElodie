using System.ComponentModel.DataAnnotations;

namespace Shopping
{
    public class PaymentTerminal
    {
        #region private attributes
        private Checkout checkout = new Checkout();
        #endregion private attributes

        #region public methods 
        public void Cash(float balance)
        {
            throw new NotImplementedException();
        }
        public void DisplayInstruction()
        {
            throw new NotImplementedException();
        }
        public void InsertCard(CreditCard card)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard()
        {
            throw new NotImplementedException();
        }

        #endregion public methodes
    }
}
