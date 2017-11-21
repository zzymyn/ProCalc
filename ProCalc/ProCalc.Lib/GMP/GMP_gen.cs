using System;
using System.Text;
using System.Runtime.InteropServices;

namespace ProCalc.Lib.GMP
{
    internal static partial class GMP
    {
        // Skipped __declspec - __dllexport__ => _EXPORT
        // Skipped __declspec - __dllimport__ => _IMPORT
        // Skipped __declspec - dllexport => _EXPORT
        // Skipped __declspec - dllimport => _IMPORT
        // Skipped gmp_randinit - gmp_randstate_t,gmp_randalg_t,... => void
        // Skipped gmp_randinit_default - gmp_randstate_t => void
        // Skipped gmp_randinit_lc_2exp - gmp_randstate_t,mpz_srcptr,unsigned long int,mp_bitcnt_t => void
        // Skipped gmp_randinit_lc_2exp_size - gmp_randstate_t,mp_bitcnt_t => int
        // Skipped gmp_randinit_mt - gmp_randstate_t => void
        // Skipped gmp_randinit_set - gmp_randstate_t,const __gmp_randstate_struct * => void
        // Skipped gmp_randseed - gmp_randstate_t,mpz_srcptr => void
        // Skipped gmp_randseed_ui - gmp_randstate_t,unsigned long int => void
        // Skipped gmp_randclear - gmp_randstate_t => void
        // Skipped gmp_urandomb_ui - gmp_randstate_t,unsigned long => unsigned long
        // Skipped gmp_urandomm_ui - gmp_randstate_t,unsigned long => unsigned long
        // Skipped gmp_asprintf - char **,const char *,... => int
        // Skipped gmp_fprintf - FILE *,const char *,... => int
        // Skipped gmp_obstack_printf - struct obstack *,const char *,... => int
        // Skipped gmp_obstack_vprintf - struct obstack *,const char *,va_list => int
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_printf")]
        internal static extern int gmp_printf(string a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_snprintf")]
        internal static extern int gmp_snprintf(StringBuilder a0, ulong a1, string a2, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_sprintf")]
        internal static extern int gmp_sprintf(StringBuilder a0, string a1, __arglist);
        // Skipped gmp_vasprintf - char **,const char *,va_list => int
        // Skipped gmp_vfprintf - FILE *,const char *,va_list => int
        // Skipped gmp_vprintf - const char *,va_list => int
        // Skipped gmp_vsnprintf - char *,size_t,const char *,va_list => int
        // Skipped gmp_vsprintf - char *,const char *,va_list => int
        // Skipped gmp_fscanf - FILE *,const char *,... => int
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_scanf")]
        internal static extern int gmp_scanf(string a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_sscanf")]
        internal static extern int gmp_sscanf(string a0, string a1, __arglist);
        // Skipped gmp_vfscanf - FILE *,const char *,va_list => int
        // Skipped gmp_vscanf - const char *,va_list => int
        // Skipped gmp_vsscanf - const char *,const char *,va_list => int
        [DllImport("libgmp-10.dll", EntryPoint = "__g_mpz_realloc")]
        internal static extern /* void* */ IntPtr _mpz_realloc([In, Out] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_abs")]
        internal static extern void mpz_abs([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_add")]
        internal static extern void mpz_add([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_add_ui")]
        internal static extern void mpz_add_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_addmul")]
        internal static extern void mpz_addmul([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_addmul_ui")]
        internal static extern void mpz_addmul_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_and")]
        internal static extern void mpz_and([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_array_init")]
        internal static extern void mpz_array_init([In, Out] ref mpz_t a0, int a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_bin_ui")]
        internal static extern void mpz_bin_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_bin_uiui")]
        internal static extern void mpz_bin_uiui([In, Out] ref mpz_t a0, uint a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_q")]
        internal static extern void mpz_cdiv_q([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_q_2exp")]
        internal static extern void mpz_cdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_q_ui")]
        internal static extern uint mpz_cdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_qr")]
        internal static extern void mpz_cdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_qr_ui")]
        internal static extern uint mpz_cdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r")]
        internal static extern void mpz_cdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r_2exp")]
        internal static extern void mpz_cdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r_ui")]
        internal static extern uint mpz_cdiv_r_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_ui")]
        internal static extern uint mpz_cdiv_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clear")]
        internal static extern void mpz_clear([In, Out] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clears")]
        internal static extern void mpz_clears([In, Out] ref mpz_t a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clrbit")]
        internal static extern void mpz_clrbit([In, Out] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cmp")]
        internal static extern int mpz_cmp([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cmp_d")]
        internal static extern int mpz_cmp_d([In] ref mpz_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__g_mpz_cmp_si")]
        internal static extern int _mpz_cmp_si([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__g_mpz_cmp_ui")]
        internal static extern int _mpz_cmp_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cmpabs")]
        internal static extern int mpz_cmpabs([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cmpabs_d")]
        internal static extern int mpz_cmpabs_d([In] ref mpz_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cmpabs_ui")]
        internal static extern int mpz_cmpabs_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_com")]
        internal static extern void mpz_com([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_combit")]
        internal static extern void mpz_combit([In, Out] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_congruent_p")]
        internal static extern int mpz_congruent_p([In] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_congruent_2exp_p")]
        internal static extern int mpz_congruent_2exp_p([In] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_congruent_ui_p")]
        internal static extern int mpz_congruent_ui_p([In] ref mpz_t a0, uint a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_divexact")]
        internal static extern void mpz_divexact([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_divexact_ui")]
        internal static extern void mpz_divexact_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_divisible_p")]
        internal static extern int mpz_divisible_p([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_divisible_ui_p")]
        internal static extern int mpz_divisible_ui_p([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_divisible_2exp_p")]
        internal static extern int mpz_divisible_2exp_p([In] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_dump")]
        internal static extern void mpz_dump([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_export")]
        internal static extern /* void* */ IntPtr mpz_export(/* void* */ IntPtr a0, ref ulong a1, int a2, ulong a3, int a4, ulong a5, [In] ref mpz_t a6);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fac_ui")]
        internal static extern void mpz_fac_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_2fac_ui")]
        internal static extern void mpz_2fac_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mfac_uiui")]
        internal static extern void mpz_mfac_uiui([In, Out] ref mpz_t a0, uint a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_primorial_ui")]
        internal static extern void mpz_primorial_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_q")]
        internal static extern void mpz_fdiv_q([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_q_2exp")]
        internal static extern void mpz_fdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_q_ui")]
        internal static extern uint mpz_fdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_qr")]
        internal static extern void mpz_fdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_qr_ui")]
        internal static extern uint mpz_fdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_r")]
        internal static extern void mpz_fdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_r_2exp")]
        internal static extern void mpz_fdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_r_ui")]
        internal static extern uint mpz_fdiv_r_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_ui")]
        internal static extern uint mpz_fdiv_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fib_ui")]
        internal static extern void mpz_fib_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fib2_ui")]
        internal static extern void mpz_fib2_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_sint_p")]
        internal static extern int mpz_fits_sint_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_slong_p")]
        internal static extern int mpz_fits_slong_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_sshort_p")]
        internal static extern int mpz_fits_sshort_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_uint_p")]
        internal static extern int mpz_fits_uint_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_ulong_p")]
        internal static extern int mpz_fits_ulong_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fits_ushort_p")]
        internal static extern int mpz_fits_ushort_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_gcd")]
        internal static extern void mpz_gcd([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_gcd_ui")]
        internal static extern uint mpz_gcd_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_gcdext")]
        internal static extern void mpz_gcdext([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In, Out] ref mpz_t a2, [In] ref mpz_t a3, [In] ref mpz_t a4);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_get_d")]
        internal static extern double mpz_get_d([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_get_d_2exp")]
        internal static extern double mpz_get_d_2exp(ref int a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_get_si")]
        internal static extern int mpz_get_si([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_get_str")]
        internal static extern /* char* */ IntPtr mpz_get_str(StringBuilder a0, int a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_get_ui")]
        internal static extern uint mpz_get_ui([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_getlimbn")]
        internal static extern ulong mpz_getlimbn([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_hamdist")]
        internal static extern ulong mpz_hamdist([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_import")]
        internal static extern void mpz_import([In, Out] ref mpz_t a0, ulong a1, int a2, ulong a3, int a4, ulong a5, /* const void* */ IntPtr a6);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init")]
        internal static extern void mpz_init([In, Out] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init2")]
        internal static extern void mpz_init2([In, Out] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_inits")]
        internal static extern void mpz_inits([In, Out] ref mpz_t a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init_set")]
        internal static extern void mpz_init_set([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init_set_d")]
        internal static extern void mpz_init_set_d([In, Out] ref mpz_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init_set_si")]
        internal static extern void mpz_init_set_si([In, Out] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init_set_str")]
        internal static extern int mpz_init_set_str([In, Out] ref mpz_t a0, string a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init_set_ui")]
        internal static extern void mpz_init_set_ui([In, Out] ref mpz_t a0, uint a1);
        // Skipped mpz_inp_raw - mpz_ptr,FILE * => size_t
        // Skipped mpz_inp_str - mpz_ptr,FILE *,int => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_invert")]
        internal static extern int mpz_invert([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_ior")]
        internal static extern void mpz_ior([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_jacobi")]
        internal static extern int mpz_jacobi([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_kronecker_si")]
        internal static extern int mpz_kronecker_si([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_kronecker_ui")]
        internal static extern int mpz_kronecker_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_si_kronecker")]
        internal static extern int mpz_si_kronecker(int a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_ui_kronecker")]
        internal static extern int mpz_ui_kronecker(uint a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_lcm")]
        internal static extern void mpz_lcm([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_lcm_ui")]
        internal static extern void mpz_lcm_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_lucnum_ui")]
        internal static extern void mpz_lucnum_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_lucnum2_ui")]
        internal static extern void mpz_lucnum2_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_millerrabin")]
        internal static extern int mpz_millerrabin([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mod")]
        internal static extern void mpz_mod([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mul")]
        internal static extern void mpz_mul([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mul_2exp")]
        internal static extern void mpz_mul_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mul_si")]
        internal static extern void mpz_mul_si([In, Out] ref mpz_t a0, [In] ref mpz_t a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_mul_ui")]
        internal static extern void mpz_mul_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_neg")]
        internal static extern void mpz_neg([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_nextprime")]
        internal static extern void mpz_nextprime([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        // Skipped mpz_out_raw - FILE *,mpz_srcptr => size_t
        // Skipped mpz_out_str - FILE *,int,mpz_srcptr => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_perfect_power_p")]
        internal static extern int mpz_perfect_power_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_perfect_square_p")]
        internal static extern int mpz_perfect_square_p([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_popcount")]
        internal static extern ulong mpz_popcount([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_pow_ui")]
        internal static extern void mpz_pow_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_powm")]
        internal static extern void mpz_powm([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_powm_sec")]
        internal static extern void mpz_powm_sec([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_powm_ui")]
        internal static extern void mpz_powm_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_probab_prime_p")]
        internal static extern int mpz_probab_prime_p([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_random")]
        internal static extern void mpz_random([In, Out] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_random2")]
        internal static extern void mpz_random2([In, Out] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_realloc2")]
        internal static extern void mpz_realloc2([In, Out] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_remove")]
        internal static extern ulong mpz_remove([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_root")]
        internal static extern int mpz_root([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_rootrem")]
        internal static extern void mpz_rootrem([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        // Skipped mpz_rrandomb - mpz_ptr,gmp_randstate_t,mp_bitcnt_t => void
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_scan0")]
        internal static extern ulong mpz_scan0([In] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_scan1")]
        internal static extern ulong mpz_scan1([In] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set")]
        internal static extern void mpz_set([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_d")]
        internal static extern void mpz_set_d([In, Out] ref mpz_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_f")]
        internal static extern void mpz_set_f([In, Out] ref mpz_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_q")]
        internal static extern void mpz_set_q([In, Out] ref mpz_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_si")]
        internal static extern void mpz_set_si([In, Out] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_str")]
        internal static extern int mpz_set_str([In, Out] ref mpz_t a0, string a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_set_ui")]
        internal static extern void mpz_set_ui([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_setbit")]
        internal static extern void mpz_setbit([In, Out] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_size")]
        internal static extern ulong mpz_size([In] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_sizeinbase")]
        internal static extern ulong mpz_sizeinbase([In] ref mpz_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_sqrt")]
        internal static extern void mpz_sqrt([In, Out] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_sqrtrem")]
        internal static extern void mpz_sqrtrem([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_sub")]
        internal static extern void mpz_sub([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_sub_ui")]
        internal static extern void mpz_sub_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_ui_sub")]
        internal static extern void mpz_ui_sub([In, Out] ref mpz_t a0, uint a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_submul")]
        internal static extern void mpz_submul([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_submul_ui")]
        internal static extern void mpz_submul_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_swap")]
        internal static extern void mpz_swap([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_ui")]
        internal static extern uint mpz_tdiv_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_q")]
        internal static extern void mpz_tdiv_q([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_q_2exp")]
        internal static extern void mpz_tdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_q_ui")]
        internal static extern uint mpz_tdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_qr")]
        internal static extern void mpz_tdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_qr_ui")]
        internal static extern uint mpz_tdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r")]
        internal static extern void mpz_tdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r_2exp")]
        internal static extern void mpz_tdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r_ui")]
        internal static extern uint mpz_tdiv_r_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tstbit")]
        internal static extern int mpz_tstbit([In] ref mpz_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_ui_pow_ui")]
        internal static extern void mpz_ui_pow_ui([In, Out] ref mpz_t a0, uint a1, uint a2);
        // Skipped mpz_urandomb - mpz_ptr,gmp_randstate_t,mp_bitcnt_t => void
        // Skipped mpz_urandomm - mpz_ptr,gmp_randstate_t,mpz_srcptr => void
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_xor")]
        internal static extern void mpz_xor([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        // Skipped mpz_limbs_read - mpz_srcptr => mp_srcptr
        // Skipped mpz_limbs_write - mpz_ptr,mp_size_t => mp_ptr
        // Skipped mpz_limbs_modify - mpz_ptr,mp_size_t => mp_ptr
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_limbs_finish")]
        internal static extern void mpz_limbs_finish([In, Out] ref mpz_t a0, int a1);
        // Skipped mpz_roinit_n - mpz_ptr,mp_srcptr,mp_size_t => mpz_srcptr
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_abs")]
        internal static extern void mpq_abs([In, Out] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_add")]
        internal static extern void mpq_add([In, Out] ref mpq_t a0, [In] ref mpq_t a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_canonicalize")]
        internal static extern void mpq_canonicalize([In, Out] ref mpq_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_clear")]
        internal static extern void mpq_clear([In, Out] ref mpq_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_clears")]
        internal static extern void mpq_clears([In, Out] ref mpq_t a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_cmp")]
        internal static extern int mpq_cmp([In] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__g_mpq_cmp_si")]
        internal static extern int _mpq_cmp_si([In] ref mpq_t a0, int a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__g_mpq_cmp_ui")]
        internal static extern int _mpq_cmp_ui([In] ref mpq_t a0, uint a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_cmp_z")]
        internal static extern int mpq_cmp_z([In] ref mpq_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_div")]
        internal static extern void mpq_div([In, Out] ref mpq_t a0, [In] ref mpq_t a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_div_2exp")]
        internal static extern void mpq_div_2exp([In, Out] ref mpq_t a0, [In] ref mpq_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_equal")]
        internal static extern int mpq_equal([In] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_get_num")]
        internal static extern void mpq_get_num([In, Out] ref mpz_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_get_den")]
        internal static extern void mpq_get_den([In, Out] ref mpz_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_get_d")]
        internal static extern double mpq_get_d([In] ref mpq_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_get_str")]
        internal static extern /* char* */ IntPtr mpq_get_str(StringBuilder a0, int a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_init")]
        internal static extern void mpq_init([In, Out] ref mpq_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_inits")]
        internal static extern void mpq_inits([In, Out] ref mpq_t a0, __arglist);
        // Skipped mpq_inp_str - mpq_ptr,FILE *,int => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_inv")]
        internal static extern void mpq_inv([In, Out] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_mul")]
        internal static extern void mpq_mul([In, Out] ref mpq_t a0, [In] ref mpq_t a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_mul_2exp")]
        internal static extern void mpq_mul_2exp([In, Out] ref mpq_t a0, [In] ref mpq_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_neg")]
        internal static extern void mpq_neg([In, Out] ref mpq_t a0, [In] ref mpq_t a1);
        // Skipped mpq_out_str - FILE *,int,mpq_srcptr => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set")]
        internal static extern void mpq_set([In, Out] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_d")]
        internal static extern void mpq_set_d([In, Out] ref mpq_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_den")]
        internal static extern void mpq_set_den([In, Out] ref mpq_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_f")]
        internal static extern void mpq_set_f([In, Out] ref mpq_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_num")]
        internal static extern void mpq_set_num([In, Out] ref mpq_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_si")]
        internal static extern void mpq_set_si([In, Out] ref mpq_t a0, int a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_str")]
        internal static extern int mpq_set_str([In, Out] ref mpq_t a0, string a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_ui")]
        internal static extern void mpq_set_ui([In, Out] ref mpq_t a0, uint a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_set_z")]
        internal static extern void mpq_set_z([In, Out] ref mpq_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_sub")]
        internal static extern void mpq_sub([In, Out] ref mpq_t a0, [In] ref mpq_t a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_swap")]
        internal static extern void mpq_swap([In, Out] ref mpq_t a0, [In, Out] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_abs")]
        internal static extern void mpf_abs([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_add")]
        internal static extern void mpf_add([In, Out] ref mpf_t a0, [In] ref mpf_t a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_add_ui")]
        internal static extern void mpf_add_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_ceil")]
        internal static extern void mpf_ceil([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_clear")]
        internal static extern void mpf_clear([In, Out] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_clears")]
        internal static extern void mpf_clears([In, Out] ref mpf_t a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_cmp")]
        internal static extern int mpf_cmp([In] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_cmp_z")]
        internal static extern int mpf_cmp_z([In] ref mpf_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_cmp_d")]
        internal static extern int mpf_cmp_d([In] ref mpf_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_cmp_si")]
        internal static extern int mpf_cmp_si([In] ref mpf_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_cmp_ui")]
        internal static extern int mpf_cmp_ui([In] ref mpf_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_div")]
        internal static extern void mpf_div([In, Out] ref mpf_t a0, [In] ref mpf_t a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_div_2exp")]
        internal static extern void mpf_div_2exp([In, Out] ref mpf_t a0, [In] ref mpf_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_div_ui")]
        internal static extern void mpf_div_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_dump")]
        internal static extern void mpf_dump([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_eq")]
        internal static extern int mpf_eq([In] ref mpf_t a0, [In] ref mpf_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_sint_p")]
        internal static extern int mpf_fits_sint_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_slong_p")]
        internal static extern int mpf_fits_slong_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_sshort_p")]
        internal static extern int mpf_fits_sshort_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_uint_p")]
        internal static extern int mpf_fits_uint_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_ulong_p")]
        internal static extern int mpf_fits_ulong_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_fits_ushort_p")]
        internal static extern int mpf_fits_ushort_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_floor")]
        internal static extern void mpf_floor([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_d")]
        internal static extern double mpf_get_d([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_d_2exp")]
        internal static extern double mpf_get_d_2exp(ref int a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_default_prec")]
        internal static extern ulong mpf_get_default_prec( );
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_prec")]
        internal static extern ulong mpf_get_prec([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_si")]
        internal static extern int mpf_get_si([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_str")]
        internal static extern /* char* */ IntPtr mpf_get_str(StringBuilder a0, ref int a1, int a2, ulong a3, [In] ref mpf_t a4);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_ui")]
        internal static extern uint mpf_get_ui([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init")]
        internal static extern void mpf_init([In, Out] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init2")]
        internal static extern void mpf_init2([In, Out] ref mpf_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_inits")]
        internal static extern void mpf_inits([In, Out] ref mpf_t a0, __arglist);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init_set")]
        internal static extern void mpf_init_set([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init_set_d")]
        internal static extern void mpf_init_set_d([In, Out] ref mpf_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init_set_si")]
        internal static extern void mpf_init_set_si([In, Out] ref mpf_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init_set_str")]
        internal static extern int mpf_init_set_str([In, Out] ref mpf_t a0, string a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init_set_ui")]
        internal static extern void mpf_init_set_ui([In, Out] ref mpf_t a0, uint a1);
        // Skipped mpf_inp_str - mpf_ptr,FILE *,int => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_integer_p")]
        internal static extern int mpf_integer_p([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_mul")]
        internal static extern void mpf_mul([In, Out] ref mpf_t a0, [In] ref mpf_t a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_mul_2exp")]
        internal static extern void mpf_mul_2exp([In, Out] ref mpf_t a0, [In] ref mpf_t a1, ulong a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_mul_ui")]
        internal static extern void mpf_mul_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_neg")]
        internal static extern void mpf_neg([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        // Skipped mpf_out_str - FILE *,int,size_t,mpf_srcptr => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_pow_ui")]
        internal static extern void mpf_pow_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_random2")]
        internal static extern void mpf_random2([In, Out] ref mpf_t a0, int a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_reldiff")]
        internal static extern void mpf_reldiff([In, Out] ref mpf_t a0, [In] ref mpf_t a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set")]
        internal static extern void mpf_set([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_d")]
        internal static extern void mpf_set_d([In, Out] ref mpf_t a0, double a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_default_prec")]
        internal static extern void mpf_set_default_prec(ulong a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_prec")]
        internal static extern void mpf_set_prec([In, Out] ref mpf_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_prec_raw")]
        internal static extern void mpf_set_prec_raw([In, Out] ref mpf_t a0, ulong a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_q")]
        internal static extern void mpf_set_q([In, Out] ref mpf_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_si")]
        internal static extern void mpf_set_si([In, Out] ref mpf_t a0, int a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_str")]
        internal static extern int mpf_set_str([In, Out] ref mpf_t a0, string a1, int a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_ui")]
        internal static extern void mpf_set_ui([In, Out] ref mpf_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_z")]
        internal static extern void mpf_set_z([In, Out] ref mpf_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_size")]
        internal static extern ulong mpf_size([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_sqrt")]
        internal static extern void mpf_sqrt([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_sqrt_ui")]
        internal static extern void mpf_sqrt_ui([In, Out] ref mpf_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_sub")]
        internal static extern void mpf_sub([In, Out] ref mpf_t a0, [In] ref mpf_t a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_sub_ui")]
        internal static extern void mpf_sub_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_swap")]
        internal static extern void mpf_swap([In, Out] ref mpf_t a0, [In, Out] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_trunc")]
        internal static extern void mpf_trunc([In, Out] ref mpf_t a0, [In] ref mpf_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_ui_div")]
        internal static extern void mpf_ui_div([In, Out] ref mpf_t a0, uint a1, [In] ref mpf_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_ui_sub")]
        internal static extern void mpf_ui_sub([In, Out] ref mpf_t a0, uint a1, [In] ref mpf_t a2);
        // Skipped mpf_urandomb - mpf_t,gmp_randstate_t,mp_bitcnt_t => void
        // Skipped mpn_add - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_add_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_add_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_addmul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_cmp - mp_srcptr,mp_srcptr,mp_size_t => int
        // Skipped mpn_zero_p - mp_srcptr,mp_size_t => int
        // Skipped mpn_divexact_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => void
        // Skipped mpn_divexact_by3c - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_divrem - mp_ptr,mp_size_t,mp_ptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_divrem_1 - mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_divrem_2 - mp_ptr,mp_size_t,mp_ptr,mp_size_t,mp_srcptr => mp_limb_t
        // Skipped mpn_div_qr_1 - mp_ptr,mp_limb_t *,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_div_qr_2 - mp_ptr,mp_ptr,mp_srcptr,mp_size_t,mp_srcptr => mp_limb_t
        // Skipped mpn_gcd - mp_ptr,mp_ptr,mp_size_t,mp_ptr,mp_size_t => mp_size_t
        // Skipped mpn_gcd_1 - mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_gcdext_1 - mp_limb_signed_t *,mp_limb_signed_t *,mp_limb_t,mp_limb_t => mp_limb_t
        // Skipped mpn_gcdext - mp_ptr,mp_ptr,mp_size_t *,mp_ptr,mp_size_t,mp_ptr,mp_size_t => mp_size_t
        // Skipped mpn_get_str - unsigned char *,int,mp_ptr,mp_size_t => size_t
        // Skipped mpn_hamdist - mp_srcptr,mp_srcptr,mp_size_t => mp_bitcnt_t
        // Skipped mpn_lshift - mp_ptr,mp_srcptr,mp_size_t,unsigned int => mp_limb_t
        // Skipped mpn_mod_1 - mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_mul - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_mul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_mul_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_sqr - mp_ptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_neg - mp_ptr,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_com - mp_ptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_perfect_square_p - mp_srcptr,mp_size_t => int
        // Skipped mpn_perfect_power_p - mp_srcptr,mp_size_t => int
        // Skipped mpn_popcount - mp_srcptr,mp_size_t => mp_bitcnt_t
        // Skipped mpn_pow_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t,mp_ptr => mp_size_t
        // Skipped mpn_preinv_mod_1 - mp_srcptr,mp_size_t,mp_limb_t,mp_limb_t => mp_limb_t
        // Skipped mpn_random - mp_ptr,mp_size_t => void
        // Skipped mpn_random2 - mp_ptr,mp_size_t => void
        // Skipped mpn_rshift - mp_ptr,mp_srcptr,mp_size_t,unsigned int => mp_limb_t
        // Skipped mpn_scan0 - mp_srcptr,mp_bitcnt_t => mp_bitcnt_t
        // Skipped mpn_scan1 - mp_srcptr,mp_bitcnt_t => mp_bitcnt_t
        // Skipped mpn_set_str - mp_ptr,const unsigned char *,size_t,int => mp_size_t
        // Skipped mpn_sizeinbase - mp_srcptr,mp_size_t,int => size_t
        // Skipped mpn_sqrtrem - mp_ptr,mp_ptr,mp_srcptr,mp_size_t => mp_size_t
        // Skipped mpn_sub - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_sub_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_sub_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_submul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
        // Skipped mpn_tdiv_qr - mp_ptr,mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => void
        // Skipped mpn_and_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_andn_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_nand_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_ior_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_iorn_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_nior_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_xor_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_xnor_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_copyi - mp_ptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_copyd - mp_ptr,mp_srcptr,mp_size_t => void
        // Skipped mpn_zero - mp_ptr,mp_size_t => void
        // Skipped mpn_cnd_add_n - mp_limb_t,mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_cnd_sub_n - mp_limb_t,mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
        // Skipped mpn_sec_add_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t,mp_ptr => mp_limb_t
        // Skipped mpn_sec_add_1_itch - mp_size_t => mp_size_t
        // Skipped mpn_sec_sub_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t,mp_ptr => mp_limb_t
        // Skipped mpn_sec_sub_1_itch - mp_size_t => mp_size_t
        // Skipped mpn_cnd_swap - mp_limb_t,volatile mp_limb_t *,volatile mp_limb_t *,mp_size_t => void
        // Skipped mpn_sec_mul - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t,mp_ptr => void
        // Skipped mpn_sec_mul_itch - mp_size_t,mp_size_t => mp_size_t
        // Skipped mpn_sec_sqr - mp_ptr,mp_srcptr,mp_size_t,mp_ptr => void
        // Skipped mpn_sec_sqr_itch - mp_size_t => mp_size_t
        // Skipped mpn_sec_powm - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_bitcnt_t,mp_srcptr,mp_size_t,mp_ptr => void
        // Skipped mpn_sec_powm_itch - mp_size_t,mp_bitcnt_t,mp_size_t => mp_size_t
        // Skipped mpn_sec_tabselect - volatile mp_limb_t *,volatile const mp_limb_t *,mp_size_t,mp_size_t,mp_size_t => void
        // Skipped mpn_sec_div_qr - mp_ptr,mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_ptr => mp_limb_t
        // Skipped mpn_sec_div_qr_itch - mp_size_t,mp_size_t => mp_size_t
        // Skipped mpn_sec_div_r - mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_ptr => void
        // Skipped mpn_sec_div_r_itch - mp_size_t,mp_size_t => mp_size_t
        // Skipped mpn_sec_invert - mp_ptr,mp_ptr,mp_srcptr,mp_size_t,mp_bitcnt_t,mp_ptr => int
        // Skipped mpn_sec_invert_itch - mp_size_t => mp_size_t
    }
}

