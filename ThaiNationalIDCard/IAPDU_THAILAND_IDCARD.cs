
namespace ThaiNationalIDCard
{
    interface IAPDU_THAILAND_IDCARD
    {
        // Get response
        byte[] APDU_GET_RESPONSE();
        // MOI AID
        byte[] AID_MOI { get; set; }

        // Select/Reset
        byte[] APDU_SELECT(byte[] AID);

        // Citizen ID
        byte[] EF_CID { get; set; }

        // Fullname Thai + Eng + BirthDate + Sex
        byte[] EF_PERSON_INFO { get; set; }

        // Address
        byte[] EF_ADDRESS { get; set; }

        // issue/expire
        byte[] EF_CARD_ISSUE_EXPIRE { get; set; }

        // issuer
        byte[] EF_CARD_ISSUER { get; set; }

        // photo
        byte[][] EF_CARD_PHOTO { get; set; }

        byte[] EF_CHIPNO { get; set; }
        byte[] EF_BP1NO { get; set; }
        byte[] EF_ISSUER_CODE { get; set; }
        byte[] EF_VERSION { get; set; }
    }
}
