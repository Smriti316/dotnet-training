using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository.MemberRepository;

namespace LibraryManagementSystem.Services.MemberService
{
    public class MemberService : IMemberService
    {
        private readonly MemberRepository _memberRepository = new MemberRepository();

        public void AddMember(Member member)
        {
            member.JoinedDate = DateTime.Now;
            member.ExpirationDate = DateTime.Now.AddDays(90);
            member.CreatedBy = "admin";
            member.CreatedDate = DateTime.Now;
            _memberRepository.AddMember(member);
        }

        public bool DeleteMember(int memberId)
        {
            return _memberRepository.DeleteMember(memberId);
        }

        public bool EditMember(Member member)
        {
            return _memberRepository.EditMember(member);
        }

        public void RenewMembership(Member member)
        {
            member.ExpirationDate = DateTime.Now.AddDays(90);
            member.ModifiedBy = "admin";
            member.ModifiedDate = DateTime.Now;
            _memberRepository.RenewMembership(member);
        }

        public List<Member> SearchMembers(string searchParam)
        {
            return _memberRepository.SearchMembers(searchParam);
        }

        public List<Member> ViewAllMembers()
        {
            return _memberRepository.ViewAllMembers();
        }
    }
}
