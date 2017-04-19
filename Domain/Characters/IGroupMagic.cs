namespace Domain.Characters
{
    public interface IGroupMagic
    {
        void AddGroupMember(IMagicReceiver receiver);
        void RemoveGroupMember(IMagicReceiver receiver);
        void CastSpellOnGroup();
    }
}
