namespace SVFSharpExampleMod

open StardewModdingAPI
open StardewValley

type public ModEntry() =
    inherit Mod()

    override this.Entry(helper: IModHelper) =
        helper.Events.Input.ButtonPressed.Add <| fun e ->
            if not Context.IsWorldReady then
                ()
            else
                this.Monitor.Log($"{Game1.player.name} pressed {e.Button}", LogLevel.Debug)
