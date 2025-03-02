using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace domain.Enums
{
    public enum StatusTarefa
    {
        [Description("Pendente")]
        Pendente,

        [Description("Em Andamento")]
        EmAndamento,

        [Description("Concluído")]
        Concluida
    }
}