using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzChallBase.Modules;
using EzChallBase.Game;
using EzChallBase.Game.Objects;
using EzChallBase.Game.Spells;
using System.Windows.Forms;
using System.Drawing;

namespace EzChallBase
{
    class Main
    {
        public static void OnMain()
        {
            if (Utils.IsKeyPressed(Keys.X))
            {
                //OrbService.Orbwalker.Orbwalk();
                //int objectUnderMouse = Engine.GetObjectUnderMouse();
                //MessageBox.Show(objectUnderMouse.ToString());

                /*Point EnemyPosition = ObjectManager.GetEnemyPosition();

                if (EnemyPosition != Point.Empty)
                {
                    SpellBook.CastSpell(SpellBook.SpellSlot.Q, EnemyPosition);

                    SpellBook.SpellSlot[] SpellArray = new SpellBook.SpellSlot[]
                    {
                        SpellBook.SpellSlot.Q,
                        SpellBook.SpellSlot.W,
                        SpellBook.SpellSlot.E
                    };

                    SpellBook.CastMultiSpells(SpellArray, EnemyPosition);
                }
                else
                {
                    Engine.IssueOrder(Enums.GameObjectOrder.MoveTo, Cursor.Position);
                }*/
            }

            if (Utils.IsKeyPressed(Keys.PageUp))
            {
                var zoomInstance = Memory.Read<int>(OffsetManager.Instances.ZoomInstance);
                var zoomAmount = Memory.Read<float>(zoomInstance + OffsetManager.Instances.ZoomAmount);
                Memory.Write<float>(zoomInstance + OffsetManager.Instances.ZoomAmount, zoomAmount + 1.0f);
            }

            if (Utils.IsKeyPressed(Keys.PageDown))
            {
                var zoomInstance = Memory.Read<int>(OffsetManager.Instances.ZoomInstance);
                var zoomAmount = Memory.Read<float>(zoomInstance + OffsetManager.Instances.ZoomAmount);
                Memory.Write<float>(zoomInstance + OffsetManager.Instances.ZoomAmount, zoomAmount - 1.0f);
            }
        }
    }
}
