using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knesset___7
{
    public class Party
    {
        private String partyName;   //  שם המפלגה
        private String headmaster;  //  שם יו"ר המפלגה
        private String politicalView;   //  עמדה פוליטית
        private int mandats;    //  כמות מנדטים

        public Party(string partyName, string headmaster, string politicalView, int mandats)
        {
            this.partyName = partyName;
            this.headmaster = headmaster;
            this.politicalView = politicalView;
            this.mandats = mandats;
        }

        //Get
        public string GetPartyName() { return partyName; }
        public string GetHeadMaster() {  return headmaster; }
        public string GetPoliticalView() {  return politicalView; }
        public int GetMandats() {  return mandats; }

        //Set
        public void SetPartyName(string partyName) {  this.partyName = partyName; }
        public void SetHeadMaster(string headMaster) {  this.headmaster = headMaster; }
        public void SetPoliticalView(string politicalView) { this.politicalView = politicalView; }
        public void SetMandats(int mandats) { this.mandats = mandats; }
    }
}
