namespace Interfaces
{
    public interface IHealthAbility
    {
        public int GetHealth();
        public int GetMaxHealth();
        public void Heal(int healPoints);
        public void Damage(int damagePoints);
    }
}