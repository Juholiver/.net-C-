﻿using System.ComponentModel;

namespace APISoft.Enums
{
    public enum StatusTarefas
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3,
    }
}
