using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Services.MemberService
{
    public interface IMemberService
    {
        void AddMember(Member member);
        void EditMember(Member member);
        void DeleteMember(int memberId);
        List<Member> ViewAllMembers();
        List<Member> SearchMembers();
        void RenewMembership(Member member);
        
    }
}
