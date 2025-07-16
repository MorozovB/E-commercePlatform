using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Interfaces
{
    public interface IPaymentProcessor
    {
        /// <summary>
        /// Pay for your order through an external system.
        /// </summary>
        /// <param name="orderId">Orders ID</param>
        /// <param name="amount">amount to pay</param>
        /// <param name="currency">Code of currency</param>
        /// <returns>Returns true if the payment was successful; otherwise, returns false.</returns>
        Task<bool> ProcessPaymentAsync(Guid orderId, decimal amount, string currency);

        /// <summary>
        /// Generates a payment link for the external system .
        /// </summary>
        /// <param name="orderId">Orders ID</param>
        /// <param name="amount">amount to pay</param>
        /// <param name="currency">Code of currency</param>
        /// <returns>The task result contains the generated payment link as a string.</returns>
        Task<string> GeneratePaymentLinkAsync(Guid orderId, decimal amount, string currency);

        /// <summary>
        /// Verifies whether the payment for the specified order has been successfully processed.
        /// </summary>
        /// <param name="orderId">Orders ID.</param>
        /// <returns> true — payment confirmed, false — failed.</returns>
        Task<bool> VerifyPaymentAsync(Guid orderId);
    }
}
