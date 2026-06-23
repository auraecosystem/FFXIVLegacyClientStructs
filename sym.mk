# 0. Symlink original binaries from the workspace install (does NOT copy)
#    + dump PE structure (sanity check):
make bootstrap

# 1. Static-analysis pipeline. Requires Ghidra 12 + JDK 21
#    (`brew install ghidra` pulls openjdk@21).
make split BINARY=ffxivlogin.exe   # ~30s — sanity check
make split BINARY=ffxivgame.exe    # ~30-60 min on Apple Silicon

# 2. Inspect the work pool:
make progress

# 3. Run the Phase 3 extraction / validation pipeline:
make extract-net                   # net-class vtable → fn_rva map
make extract-gam                   # GAM property registry
make extract-paramnames            # PARAMNAME dispatchers (192/192)
make emit-gam-header               # include/net/gam_registry.h
make extract-opcodes               # Down opcode → vtable-slot
make extract-up-opcodes            # Up CPB ctor inventory
make extract-crypt-engine          # LobbyCryptEngine 9-slot decode
make validate-murmur2              # MurmurHash2 vectors
make validate-chara-make           # chara_info.rs ↔ GAM CharaMakeData
make validate-chara-list           # build_for_chara_list ↔ GAM ClientSelectData
