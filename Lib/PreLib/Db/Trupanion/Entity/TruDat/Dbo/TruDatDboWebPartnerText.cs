﻿namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWebPartnerText
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactName { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public string? Zipcode { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public int? DefaultCharityId { get; set; }
    public string? HeaderHtml { get; set; }
    public string? LogoImage { get; set; }
    public string? LogoImagePath { get; set; }
    public string? BrandShadowImage { get; set; }
    public string? BrandShadowImagePath { get; set; }
    public string? LandingPageTitle { get; set; }
    public string? OfferDetailsHtml { get; set; }
    public string? LandingPageWelcomeHtml { get; set; }
    public string? PixelTrackingLandingHtml { get; set; }
    public string? PixelTrackingQuoteHtml { get; set; }
    public string? PixelTrackingWelcomeHtml { get; set; }
    public string? WelcomePageDetailsHtml { get; set; }
    public string? TrialDisclaimerPetsHtml { get; set; }
    public string? TrialDisclaimerQuoteHtml { get; set; }
    public string? TrialReviewReplacementHtml { get; set; }
    public string? TrialQuoteResultHtml { get; set; }
    public bool? ShowBillingPage { get; set; }
    public bool? ShowCharityPage { get; set; }
    public bool? ShowDisclaimerMessage { get; set; }
    public bool? ShowLastExam { get; set; }
    public bool? ShowPromoCode { get; set; }
    public bool? ShowPetTagMessage { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? Apikey { get; set; }
    public string? PixelTrackingMedicalHtml { get; set; }
    public string? PixelTrackingOwnerHtml { get; set; }
    public string? PixelTrackingPaymentHtml { get; set; }
    public string? PixelTrackingCharityHtml { get; set; }
    public string? PixelTrackingReviewHtml { get; set; }
    public string? State { get; set; }
    public string? StateCode { get; set; }
    public string? Referral { get; set; }
    public int? ReferralId { get; set; }
    public string? Voucher { get; set; }
    public string? PromoCode { get; set; }
    public int? StateId { get; set; }
    public int? ApilevelId { get; set; }
    public int? VoucherId { get; set; }
    public string? SecurityKey { get; set; }
    public bool? VoucherActive { get; set; }
    public int? UserId { get; set; }
    public bool? ValidateRange { get; set; }
    public long? NumericRangeStart { get; set; }
    public int? CookieExpDays { get; set; }
    public string? HostingUrl { get; set; }
    public string? SalesForceId { get; set; }
    public string? BrandPhoneNumber { get; set; }
}
