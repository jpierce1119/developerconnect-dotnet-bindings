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
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// DisclosureTracking2015ContractCdReason
    /// </summary>
    [DataContract]
    public partial class DisclosureTracking2015ContractCdReason :  IEquatable<DisclosureTracking2015ContractCdReason>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets IsChangeInAPR
        /// </summary>
        [DataMember(Name="isChangeInAPR", EmitDefaultValue=false)]
        public bool? IsChangeInAPR { get; set; }

        /// <summary>
        /// Gets or Sets IsChangeInLoanProduct
        /// </summary>
        [DataMember(Name="isChangeInLoanProduct", EmitDefaultValue=false)]
        public bool? IsChangeInLoanProduct { get; set; }

        /// <summary>
        /// Gets or Sets IsPrepaymentPenaltyAdded
        /// </summary>
        [DataMember(Name="isPrepaymentPenaltyAdded", EmitDefaultValue=false)]
        public bool? IsPrepaymentPenaltyAdded { get; set; }

        /// <summary>
        /// Gets or Sets IsChangeInSettlementCharges
        /// </summary>
        [DataMember(Name="isChangeInSettlementCharges", EmitDefaultValue=false)]
        public bool? IsChangeInSettlementCharges { get; set; }

        /// <summary>
        /// Gets or Sets Is24HourAdvancePreview
        /// </summary>
        [DataMember(Name="is24HourAdvancePreview", EmitDefaultValue=false)]
        public bool? Is24HourAdvancePreview { get; set; }

        /// <summary>
        /// Gets or Sets IsToleranceCure
        /// </summary>
        [DataMember(Name="isToleranceCure", EmitDefaultValue=false)]
        public bool? IsToleranceCure { get; set; }

        /// <summary>
        /// Gets or Sets IsClericalErrorCorrection
        /// </summary>
        [DataMember(Name="isClericalErrorCorrection", EmitDefaultValue=false)]
        public bool? IsClericalErrorCorrection { get; set; }

        /// <summary>
        /// Gets or Sets IsChangedCircumstanceEligibility
        /// </summary>
        [DataMember(Name="isChangedCircumstanceEligibility", EmitDefaultValue=false)]
        public bool? IsChangedCircumstanceEligibility { get; set; }

        /// <summary>
        /// Gets or Sets IsInterestRateDependentCharges
        /// </summary>
        [DataMember(Name="isInterestRateDependentCharges", EmitDefaultValue=false)]
        public bool? IsInterestRateDependentCharges { get; set; }

        /// <summary>
        /// Gets or Sets IsRevisionsRequestedByConsumer
        /// </summary>
        [DataMember(Name="isRevisionsRequestedByConsumer", EmitDefaultValue=false)]
        public bool? IsRevisionsRequestedByConsumer { get; set; }

        /// <summary>
        /// Gets or Sets IsOther
        /// </summary>
        [DataMember(Name="isOther", EmitDefaultValue=false)]
        public bool? IsOther { get; set; }

        /// <summary>
        /// Gets or Sets OtherDescription
        /// </summary>
        [DataMember(Name="otherDescription", EmitDefaultValue=false)]
        public string OtherDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisclosureTracking2015ContractCdReason {\n");
            sb.Append("  IsChangeInAPR: ").Append(IsChangeInAPR).Append("\n");
            sb.Append("  IsChangeInLoanProduct: ").Append(IsChangeInLoanProduct).Append("\n");
            sb.Append("  IsPrepaymentPenaltyAdded: ").Append(IsPrepaymentPenaltyAdded).Append("\n");
            sb.Append("  IsChangeInSettlementCharges: ").Append(IsChangeInSettlementCharges).Append("\n");
            sb.Append("  Is24HourAdvancePreview: ").Append(Is24HourAdvancePreview).Append("\n");
            sb.Append("  IsToleranceCure: ").Append(IsToleranceCure).Append("\n");
            sb.Append("  IsClericalErrorCorrection: ").Append(IsClericalErrorCorrection).Append("\n");
            sb.Append("  IsChangedCircumstanceEligibility: ").Append(IsChangedCircumstanceEligibility).Append("\n");
            sb.Append("  IsInterestRateDependentCharges: ").Append(IsInterestRateDependentCharges).Append("\n");
            sb.Append("  IsRevisionsRequestedByConsumer: ").Append(IsRevisionsRequestedByConsumer).Append("\n");
            sb.Append("  IsOther: ").Append(IsOther).Append("\n");
            sb.Append("  OtherDescription: ").Append(OtherDescription).Append("\n");
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
            return this.Equals(input as DisclosureTracking2015ContractCdReason);
        }

        /// <summary>
        /// Returns true if DisclosureTracking2015ContractCdReason instances are equal
        /// </summary>
        /// <param name="input">Instance of DisclosureTracking2015ContractCdReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisclosureTracking2015ContractCdReason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsChangeInAPR == input.IsChangeInAPR ||
                    (this.IsChangeInAPR != null &&
                    this.IsChangeInAPR.Equals(input.IsChangeInAPR))
                ) && 
                (
                    this.IsChangeInLoanProduct == input.IsChangeInLoanProduct ||
                    (this.IsChangeInLoanProduct != null &&
                    this.IsChangeInLoanProduct.Equals(input.IsChangeInLoanProduct))
                ) && 
                (
                    this.IsPrepaymentPenaltyAdded == input.IsPrepaymentPenaltyAdded ||
                    (this.IsPrepaymentPenaltyAdded != null &&
                    this.IsPrepaymentPenaltyAdded.Equals(input.IsPrepaymentPenaltyAdded))
                ) && 
                (
                    this.IsChangeInSettlementCharges == input.IsChangeInSettlementCharges ||
                    (this.IsChangeInSettlementCharges != null &&
                    this.IsChangeInSettlementCharges.Equals(input.IsChangeInSettlementCharges))
                ) && 
                (
                    this.Is24HourAdvancePreview == input.Is24HourAdvancePreview ||
                    (this.Is24HourAdvancePreview != null &&
                    this.Is24HourAdvancePreview.Equals(input.Is24HourAdvancePreview))
                ) && 
                (
                    this.IsToleranceCure == input.IsToleranceCure ||
                    (this.IsToleranceCure != null &&
                    this.IsToleranceCure.Equals(input.IsToleranceCure))
                ) && 
                (
                    this.IsClericalErrorCorrection == input.IsClericalErrorCorrection ||
                    (this.IsClericalErrorCorrection != null &&
                    this.IsClericalErrorCorrection.Equals(input.IsClericalErrorCorrection))
                ) && 
                (
                    this.IsChangedCircumstanceEligibility == input.IsChangedCircumstanceEligibility ||
                    (this.IsChangedCircumstanceEligibility != null &&
                    this.IsChangedCircumstanceEligibility.Equals(input.IsChangedCircumstanceEligibility))
                ) && 
                (
                    this.IsInterestRateDependentCharges == input.IsInterestRateDependentCharges ||
                    (this.IsInterestRateDependentCharges != null &&
                    this.IsInterestRateDependentCharges.Equals(input.IsInterestRateDependentCharges))
                ) && 
                (
                    this.IsRevisionsRequestedByConsumer == input.IsRevisionsRequestedByConsumer ||
                    (this.IsRevisionsRequestedByConsumer != null &&
                    this.IsRevisionsRequestedByConsumer.Equals(input.IsRevisionsRequestedByConsumer))
                ) && 
                (
                    this.IsOther == input.IsOther ||
                    (this.IsOther != null &&
                    this.IsOther.Equals(input.IsOther))
                ) && 
                (
                    this.OtherDescription == input.OtherDescription ||
                    (this.OtherDescription != null &&
                    this.OtherDescription.Equals(input.OtherDescription))
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
                if (this.IsChangeInAPR != null)
                    hashCode = hashCode * 59 + this.IsChangeInAPR.GetHashCode();
                if (this.IsChangeInLoanProduct != null)
                    hashCode = hashCode * 59 + this.IsChangeInLoanProduct.GetHashCode();
                if (this.IsPrepaymentPenaltyAdded != null)
                    hashCode = hashCode * 59 + this.IsPrepaymentPenaltyAdded.GetHashCode();
                if (this.IsChangeInSettlementCharges != null)
                    hashCode = hashCode * 59 + this.IsChangeInSettlementCharges.GetHashCode();
                if (this.Is24HourAdvancePreview != null)
                    hashCode = hashCode * 59 + this.Is24HourAdvancePreview.GetHashCode();
                if (this.IsToleranceCure != null)
                    hashCode = hashCode * 59 + this.IsToleranceCure.GetHashCode();
                if (this.IsClericalErrorCorrection != null)
                    hashCode = hashCode * 59 + this.IsClericalErrorCorrection.GetHashCode();
                if (this.IsChangedCircumstanceEligibility != null)
                    hashCode = hashCode * 59 + this.IsChangedCircumstanceEligibility.GetHashCode();
                if (this.IsInterestRateDependentCharges != null)
                    hashCode = hashCode * 59 + this.IsInterestRateDependentCharges.GetHashCode();
                if (this.IsRevisionsRequestedByConsumer != null)
                    hashCode = hashCode * 59 + this.IsRevisionsRequestedByConsumer.GetHashCode();
                if (this.IsOther != null)
                    hashCode = hashCode * 59 + this.IsOther.GetHashCode();
                if (this.OtherDescription != null)
                    hashCode = hashCode * 59 + this.OtherDescription.GetHashCode();
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