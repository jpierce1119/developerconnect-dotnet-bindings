/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Schema
 *
 * Represents schema operations on Loan.
 *
 * OpenAPI spec version: 1.4.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractInterimServicingOtherTransactions
    /// </summary>
    [DataContract]
    public partial class LoanContractInterimServicingOtherTransactions :  IEquatable<LoanContractInterimServicingOtherTransactions>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name="createdById", EmitDefaultValue=false)]
        public string CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByName
        /// </summary>
        [DataMember(Name="createdByName", EmitDefaultValue=false)]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTimeUtc
        /// </summary>
        [DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? CreatedDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionName
        /// </summary>
        [DataMember(Name="institutionName", EmitDefaultValue=false)]
        public string InstitutionName { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionRouting
        /// </summary>
        [DataMember(Name="institutionRouting", EmitDefaultValue=false)]
        public string InstitutionRouting { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name="modifiedById", EmitDefaultValue=false)]
        public string ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByName
        /// </summary>
        [DataMember(Name="modifiedByName", EmitDefaultValue=false)]
        public string ModifiedByName { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTimeUtc
        /// </summary>
        [DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets ServicingPaymentMethod
        /// </summary>
        [DataMember(Name="servicingPaymentMethod", EmitDefaultValue=false)]
        public string ServicingPaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ServicingTransactionType
        /// </summary>
        [DataMember(Name="servicingTransactionType", EmitDefaultValue=false)]
        public string ServicingTransactionType { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDate
        /// </summary>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractInterimServicingOtherTransactions {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedByName: ").Append(CreatedByName).Append("\n");
            sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  InstitutionName: ").Append(InstitutionName).Append("\n");
            sb.Append("  InstitutionRouting: ").Append(InstitutionRouting).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  ModifiedByName: ").Append(ModifiedByName).Append("\n");
            sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ServicingPaymentMethod: ").Append(ServicingPaymentMethod).Append("\n");
            sb.Append("  ServicingTransactionType: ").Append(ServicingTransactionType).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractInterimServicingOtherTransactions);
        }

        /// <summary>
        /// Returns true if LoanContractInterimServicingOtherTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractInterimServicingOtherTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractInterimServicingOtherTransactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.CreatedByName == input.CreatedByName ||
                    (this.CreatedByName != null &&
                    this.CreatedByName.Equals(input.CreatedByName))
                ) && 
                (
                    this.CreatedDateTimeUtc == input.CreatedDateTimeUtc ||
                    (this.CreatedDateTimeUtc != null &&
                    this.CreatedDateTimeUtc.Equals(input.CreatedDateTimeUtc))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.InstitutionName == input.InstitutionName ||
                    (this.InstitutionName != null &&
                    this.InstitutionName.Equals(input.InstitutionName))
                ) && 
                (
                    this.InstitutionRouting == input.InstitutionRouting ||
                    (this.InstitutionRouting != null &&
                    this.InstitutionRouting.Equals(input.InstitutionRouting))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.ModifiedByName == input.ModifiedByName ||
                    (this.ModifiedByName != null &&
                    this.ModifiedByName.Equals(input.ModifiedByName))
                ) && 
                (
                    this.ModifiedDateTimeUtc == input.ModifiedDateTimeUtc ||
                    (this.ModifiedDateTimeUtc != null &&
                    this.ModifiedDateTimeUtc.Equals(input.ModifiedDateTimeUtc))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ServicingPaymentMethod == input.ServicingPaymentMethod ||
                    (this.ServicingPaymentMethod != null &&
                    this.ServicingPaymentMethod.Equals(input.ServicingPaymentMethod))
                ) && 
                (
                    this.ServicingTransactionType == input.ServicingTransactionType ||
                    (this.ServicingTransactionType != null &&
                    this.ServicingTransactionType.Equals(input.ServicingTransactionType))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CreatedById != null)
                    hashCode = hashCode * 59 + this.CreatedById.GetHashCode();
                if (this.CreatedByName != null)
                    hashCode = hashCode * 59 + this.CreatedByName.GetHashCode();
                if (this.CreatedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.CreatedDateTimeUtc.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.InstitutionName != null)
                    hashCode = hashCode * 59 + this.InstitutionName.GetHashCode();
                if (this.InstitutionRouting != null)
                    hashCode = hashCode * 59 + this.InstitutionRouting.GetHashCode();
                if (this.ModifiedById != null)
                    hashCode = hashCode * 59 + this.ModifiedById.GetHashCode();
                if (this.ModifiedByName != null)
                    hashCode = hashCode * 59 + this.ModifiedByName.GetHashCode();
                if (this.ModifiedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.ModifiedDateTimeUtc.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ServicingPaymentMethod != null)
                    hashCode = hashCode * 59 + this.ServicingPaymentMethod.GetHashCode();
                if (this.ServicingTransactionType != null)
                    hashCode = hashCode * 59 + this.ServicingTransactionType.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
