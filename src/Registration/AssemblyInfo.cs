﻿// -----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Security;

#if FEATURE_CAS_APTCA
[assembly: SecurityTransparent]
[assembly: SecurityRules(SecurityRuleSet.Level2, SkipVerificationInFullTrust=true)]
#endif //FEATURE_CAS_APTCA

#if USE_CUSTOM_KEY
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.RegistrationModel.UnitTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001000fc5993e0f511ad5e16e8b226553493e09067afc41039f70daeb94a968d664f40e69a46b617d15d3d5328be7dbedd059eb98495a3b03cb4ea4ba127444671c3c84cbc1fdc393d7e10b5ee3f31f5a29f005e5eed7e3c9c8af74f413f0004f0c2cabb22f9dd4f75a6f599784e1bab70985ef8174ca6c684278be82ce055a03ebaf")]
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.UnitTestFramework, PublicKey=00240000048000009400000006020000002400005253413100040000010001000fc5993e0f511ad5e16e8b226553493e09067afc41039f70daeb94a968d664f40e69a46b617d15d3d5328be7dbedd059eb98495a3b03cb4ea4ba127444671c3c84cbc1fdc393d7e10b5ee3f31f5a29f005e5eed7e3c9c8af74f413f0004f0c2cabb22f9dd4f75a6f599784e1bab70985ef8174ca6c684278be82ce055a03ebaf")]
#elif USE_SILVERLIGHT_KEY 
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.RegistrationModel.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100B5FC90E7027F67871E773A8FDE8938C81DD402BA65B9201D60593E96C492651E889CC13F1415EBB53FAC1131AE0BD333C5EE6021672D9718EA31A8AEBD0DA0072F25D87DBA6FC90FFD598ED4DA35E44C398C454307E8E33B8426143DAEC9F596836F97C8F74750E5975C64E2189F45DEF46B2A2B1247ADC3652BF5C308055DA9")]
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.UnitTestFramework, PublicKey=0024000004800000940000000602000000240000525341310004000001000100B5FC90E7027F67871E773A8FDE8938C81DD402BA65B9201D60593E96C492651E889CC13F1415EBB53FAC1131AE0BD333C5EE6021672D9718EA31A8AEBD0DA0072F25D87DBA6FC90FFD598ED4DA35E44C398C454307E8E33B8426143DAEC9F596836F97C8F74750E5975C64E2189F45DEF46B2A2B1247ADC3652BF5C308055DA9")]
#elif USE_ECMA_KEY
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.RegistrationModel.UnitTests, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.UnitTestFramework, PublicKey=00000000000000000400000000000000")]
#elif USE_CODEPLEX_KEY
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.RegistrationModel.UnitTests.CodePlex, PublicKey=0024000004800000940000000602000000240000525341310004000001000100616470ad6a034af669d130b58deedb7ad8544920d8a21d95bc5bb535ca673d8a49b228c5163f78f34b8df3b015fc2b99ff45b7536830a596f711b8b09f80b48a4bf20883ee5b97f50462d7e0f33440f024dae7d8f7eaf875b747619f1e772131a24dea9d5f80e5d54d95f0704f78fe84ac4b3774ce17eb00a764c295846d43e3")]
[assembly: InternalsVisibleTo("System.ComponentModel.Composition.UnitTestFramework.CodePlex, PublicKey=0024000004800000940000000602000000240000525341310004000001000100616470ad6a034af669d130b58deedb7ad8544920d8a21d95bc5bb535ca673d8a49b228c5163f78f34b8df3b015fc2b99ff45b7536830a596f711b8b09f80b48a4bf20883ee5b97f50462d7e0f33440f024dae7d8f7eaf875b747619f1e772131a24dea9d5f80e5d54d95f0704f78fe84ac4b3774ce17eb00a764c295846d43e3")]
#else
#error Unknown platform
#endif