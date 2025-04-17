using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();  // Metodun çalıştırılmasını sağlar
                    transactionScope.Complete();  // İşlem başarılıysa, değişiklikleri kaydet
                }
                catch (System.Exception e)
                {
                    transactionScope.Dispose();  // Hata meydana gelirse işlem iptal edilir (rollback)
                    throw new System.Exception(e.Message);  // Hata mesajı fırlatılır
                }
            }
        }
    }    
}
