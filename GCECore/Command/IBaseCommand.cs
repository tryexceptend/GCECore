using GCECore.GameObjects;

namespace GCECore.Command
{
    /// <summary>
    /// Базовая команда
    /// </summary>
    public interface IBaseCommand
    {
        /// <summary>
        /// Выполнение команды
        /// </summary>
        /// <param name="gmObj">Объект к которому прилагается команда</param>
        void Execute(IBaseGObj gmObj);
    }
}
