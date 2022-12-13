using DataAccess.Models;


namespace DataAccess.Repository;

public interface IMemberRepository
{
    IEnumerable<Member> GetAllMember();
    List<Member> GetMembers();
    Member GetMemberById(int memberId);

    Member GetMemberByEmail(string email);
    string GetAdminEmail();
    string GetAdminPassword();
    void CreateMember(Member member);
    void Update(Member c);
    bool Delete(int memberId);

}
