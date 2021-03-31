using GCECore.GameObjects;

namespace GCECore.Command
{
    /// <summary>
    /// Команда с возможностью отмены
    /// </summary>
    public interface ICommandWithUndo : IBaseCommand
    {
        /// <summary>
        /// Отмена предыдущей команды
        /// </summary>
        /// <param name="gmObj">Объект манипуляции команды</param>
        void Undo(IBaseGObj gmObj);
    }
}
