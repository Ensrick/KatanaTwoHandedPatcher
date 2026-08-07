# Katana Two-Handed Patcher

A deterministic Synthesis/Mutagen patcher for Skyrim Special Edition and
Anniversary Edition. It converts recognized katanas to true two-handed weapons,
normalizes their combat stats, and tags them for animation/display conditions.

## Defaults

- Animation and skill: two-handed sword / Two-Handed
- Equip slot: both hands
- Speed: 0.85
- Reach: 1.20
- Stagger: 0.90
- Damage: normalized against vanilla greatsword tiers at the faster 0.85 speed
- Keywords: replaces `WeapTypeSword` with `WeapTypeGreatsword` and adds
  `KWA_WeapTypeKatana2H`

The patcher does not change meshes, enchantments, weight, gold value, recipes,
temper recipes, names, or leveled lists.

The output remains named `.esp` but is ESL-flagged. Its only new record is the
integration keyword at local FormID `000800`, inside the valid light-plugin range.

## Detection

The installed vanilla/Dawnguard/Creation Club katanas are explicitly listed by
FormKey. Mod-added weapons are selected conservatively from strong Japanese
sword terms in their name, EditorID, model path, or keyword. `ForceInclude` and
`Exclude` accept exact `FormID:PluginName` entries for exceptions.

## Headless use

Build with `dotnet publish`, then run the executable using normal Synthesis CLI
arguments. `settings.json` is intentionally plain JSON so the same binary can be
managed without opening the Synthesis GUI.
