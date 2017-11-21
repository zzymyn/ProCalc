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
        internal static extern int gmp_printf(string a0, __arglist );
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_snprintf")]
        internal static extern int gmp_snprintf(StringBuilder a0, ulong a1, string a2, __arglist );
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_sprintf")]
        internal static extern int gmp_sprintf(StringBuilder a0, string a1, __arglist );
        // Skipped gmp_vasprintf - char **,const char *,va_list => int
        // Skipped gmp_vfprintf - FILE *,const char *,va_list => int
        // Skipped gmp_vprintf - const char *,va_list => int
        // Skipped gmp_vsnprintf - char *,size_t,const char *,va_list => int
        // Skipped gmp_vsprintf - char *,const char *,va_list => int
        // Skipped gmp_fscanf - FILE *,const char *,... => int
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_scanf")]
        internal static extern int gmp_scanf(string a0, __arglist );
        [DllImport("libgmp-10.dll", EntryPoint = "__ggmp_sscanf")]
        internal static extern int gmp_sscanf(string a0, string a1, __arglist );
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
        internal static extern void mpz_cdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_q_ui")]
        internal static extern uint mpz_cdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_qr")]
        internal static extern void mpz_cdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_qr_ui")]
        internal static extern uint mpz_cdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r")]
        internal static extern void mpz_cdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r_2exp")]
        internal static extern void mpz_cdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_r_ui")]
        internal static extern uint mpz_cdiv_r_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_cdiv_ui")]
        internal static extern uint mpz_cdiv_ui([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clear")]
        internal static extern void mpz_clear([In, Out] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clears")]
        internal static extern void mpz_clears([In, Out] ref mpz_t a0, __arglist );
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_clrbit")]
        internal static extern void mpz_clrbit([In, Out] ref mpz_t a0, uint a1);
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
        internal static extern void mpz_combit([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_congruent_p")]
        internal static extern int mpz_congruent_p([In] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_congruent_2exp_p")]
        internal static extern int mpz_congruent_2exp_p([In] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
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
        internal static extern int mpz_divisible_2exp_p([In] ref mpz_t a0, uint a1);
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
        internal static extern void mpz_fdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_q_ui")]
        internal static extern uint mpz_fdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_qr")]
        internal static extern void mpz_fdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_qr_ui")]
        internal static extern uint mpz_fdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_r")]
        internal static extern void mpz_fdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_fdiv_r_2exp")]
        internal static extern void mpz_fdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
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
        internal static extern uint mpz_hamdist([In] ref mpz_t a0, [In] ref mpz_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_import")]
        internal static extern void mpz_import([In, Out] ref mpz_t a0, ulong a1, int a2, ulong a3, int a4, ulong a5, /* const void* */ IntPtr a6);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init")]
        internal static extern void mpz_init([In, Out] ref mpz_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_init2")]
        internal static extern void mpz_init2([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_inits")]
        internal static extern void mpz_inits([In, Out] ref mpz_t a0, __arglist );
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
        internal static extern void mpz_mul_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
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
        internal static extern uint mpz_popcount([In] ref mpz_t a0);
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
        internal static extern void mpz_realloc2([In, Out] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_remove")]
        internal static extern uint mpz_remove([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_root")]
        internal static extern int mpz_root([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_rootrem")]
        internal static extern void mpz_rootrem([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        // Skipped mpz_rrandomb - mpz_ptr,gmp_randstate_t,mp_bitcnt_t => void
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_scan0")]
        internal static extern uint mpz_scan0([In] ref mpz_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_scan1")]
        internal static extern uint mpz_scan1([In] ref mpz_t a0, uint a1);
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
        internal static extern void mpz_setbit([In, Out] ref mpz_t a0, uint a1);
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
        internal static extern void mpz_tdiv_q_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_q_ui")]
        internal static extern uint mpz_tdiv_q_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_qr")]
        internal static extern void mpz_tdiv_qr([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, [In] ref mpz_t a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_qr_ui")]
        internal static extern uint mpz_tdiv_qr_ui([In, Out] ref mpz_t a0, [In, Out] ref mpz_t a1, [In] ref mpz_t a2, uint a3);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r")]
        internal static extern void mpz_tdiv_r([In, Out] ref mpz_t a0, [In] ref mpz_t a1, [In] ref mpz_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r_2exp")]
        internal static extern void mpz_tdiv_r_2exp([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tdiv_r_ui")]
        internal static extern uint mpz_tdiv_r_ui([In, Out] ref mpz_t a0, [In] ref mpz_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpz_tstbit")]
        internal static extern int mpz_tstbit([In] ref mpz_t a0, uint a1);
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
        internal static extern void mpq_clears([In, Out] ref mpq_t a0, __arglist );
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
        internal static extern void mpq_div_2exp([In, Out] ref mpq_t a0, [In] ref mpq_t a1, uint a2);
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
        internal static extern void mpq_inits([In, Out] ref mpq_t a0, __arglist );
        // Skipped mpq_inp_str - mpq_ptr,FILE *,int => size_t
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_inv")]
        internal static extern void mpq_inv([In, Out] ref mpq_t a0, [In] ref mpq_t a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_mul")]
        internal static extern void mpq_mul([In, Out] ref mpq_t a0, [In] ref mpq_t a1, [In] ref mpq_t a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpq_mul_2exp")]
        internal static extern void mpq_mul_2exp([In, Out] ref mpq_t a0, [In] ref mpq_t a1, uint a2);
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
        internal static extern void mpf_clears([In, Out] ref mpf_t a0, __arglist );
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
        internal static extern void mpf_div_2exp([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_div_ui")]
        internal static extern void mpf_div_ui([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_dump")]
        internal static extern void mpf_dump([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_eq")]
        internal static extern int mpf_eq([In] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
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
        internal static extern uint mpf_get_default_prec(  );
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_prec")]
        internal static extern uint mpf_get_prec([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_si")]
        internal static extern int mpf_get_si([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_str")]
        internal static extern /* char* */ IntPtr mpf_get_str(StringBuilder a0, ref int a1, int a2, ulong a3, [In] ref mpf_t a4);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_get_ui")]
        internal static extern uint mpf_get_ui([In] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init")]
        internal static extern void mpf_init([In, Out] ref mpf_t a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_init2")]
        internal static extern void mpf_init2([In, Out] ref mpf_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_inits")]
        internal static extern void mpf_inits([In, Out] ref mpf_t a0, __arglist );
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
        internal static extern void mpf_mul_2exp([In, Out] ref mpf_t a0, [In] ref mpf_t a1, uint a2);
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
        internal static extern void mpf_set_default_prec(uint a0);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_prec")]
        internal static extern void mpf_set_prec([In, Out] ref mpf_t a0, uint a1);
        [DllImport("libgmp-10.dll", EntryPoint = "__gmpf_set_prec_raw")]
        internal static extern void mpf_set_prec_raw([In, Out] ref mpf_t a0, uint a1);
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
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_version")]
        internal static extern string mpfr_get_version(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_patches")]
        internal static extern string mpfr_get_patches(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_buildopt_tls_p")]
        internal static extern int mpfr_buildopt_tls_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_buildopt_decimal_p")]
        internal static extern int mpfr_buildopt_decimal_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_buildopt_gmpinternals_p")]
        internal static extern int mpfr_buildopt_gmpinternals_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_buildopt_tune_case")]
        internal static extern string mpfr_buildopt_tune_case(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emin")]
        internal static extern int mpfr_get_emin(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_emin")]
        internal static extern int mpfr_set_emin(int a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emin_min")]
        internal static extern int mpfr_get_emin_min(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emin_max")]
        internal static extern int mpfr_get_emin_max(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emax")]
        internal static extern int mpfr_get_emax(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_emax")]
        internal static extern int mpfr_set_emax(int a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emax_min")]
        internal static extern int mpfr_get_emax_min(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_emax_max")]
        internal static extern int mpfr_get_emax_max(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_default_rounding_mode")]
        internal static extern void mpfr_set_default_rounding_mode(mpfr_rnd_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_default_rounding_mode")]
        internal static extern mpfr_rnd_t mpfr_get_default_rounding_mode(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_print_rnd_mode")]
        internal static extern string mpfr_print_rnd_mode(mpfr_rnd_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_flags")]
        internal static extern void mpfr_clear_flags(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_underflow")]
        internal static extern void mpfr_clear_underflow(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_overflow")]
        internal static extern void mpfr_clear_overflow(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_divby0")]
        internal static extern void mpfr_clear_divby0(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_nanflag")]
        internal static extern void mpfr_clear_nanflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_inexflag")]
        internal static extern void mpfr_clear_inexflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear_erangeflag")]
        internal static extern void mpfr_clear_erangeflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_underflow")]
        internal static extern void mpfr_set_underflow(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_overflow")]
        internal static extern void mpfr_set_overflow(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_divby0")]
        internal static extern void mpfr_set_divby0(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_nanflag")]
        internal static extern void mpfr_set_nanflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_inexflag")]
        internal static extern void mpfr_set_inexflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_erangeflag")]
        internal static extern void mpfr_set_erangeflag(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_underflow_p")]
        internal static extern int mpfr_underflow_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_overflow_p")]
        internal static extern int mpfr_overflow_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_divby0_p")]
        internal static extern int mpfr_divby0_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_nanflag_p")]
        internal static extern int mpfr_nanflag_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_inexflag_p")]
        internal static extern int mpfr_inexflag_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_erangeflag_p")]
        internal static extern int mpfr_erangeflag_p(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_check_range")]
        internal static extern int mpfr_check_range([In, Out] ref mpfr_t a0, int a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_init2")]
        internal static extern void mpfr_init2([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_init")]
        internal static extern void mpfr_init([In, Out] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clear")]
        internal static extern void mpfr_clear([In, Out] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_inits2")]
        internal static extern void mpfr_inits2(int a0, [In, Out] ref mpfr_t a1, __arglist );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_inits")]
        internal static extern void mpfr_inits([In, Out] ref mpfr_t a0, __arglist );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_clears")]
        internal static extern void mpfr_clears([In, Out] ref mpfr_t a0, __arglist );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_prec_round")]
        internal static extern int mpfr_prec_round([In, Out] ref mpfr_t a0, int a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_can_round")]
        internal static extern int mpfr_can_round([In] ref mpfr_t a0, int a1, mpfr_rnd_t a2, mpfr_rnd_t a3, int a4);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_min_prec")]
        internal static extern int mpfr_min_prec([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_exp")]
        internal static extern int mpfr_get_exp([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_exp")]
        internal static extern int mpfr_set_exp([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_prec")]
        internal static extern int mpfr_get_prec([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_prec")]
        internal static extern void mpfr_set_prec([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_prec_raw")]
        internal static extern void mpfr_set_prec_raw([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_default_prec")]
        internal static extern void mpfr_set_default_prec(int a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_default_prec")]
        internal static extern int mpfr_get_default_prec(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_d")]
        internal static extern int mpfr_set_d([In, Out] ref mpfr_t a0, double a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_flt")]
        internal static extern int mpfr_set_flt([In, Out] ref mpfr_t a0, float a1, mpfr_rnd_t a2);
        // Skipped mpfr_set_decimal64 - mpfr_ptr,_Decimal64,mpfr_rnd_t => int
        // Skipped mpfr_set_ld - mpfr_ptr,long double,mpfr_rnd_t => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_z")]
        internal static extern int mpfr_set_z([In, Out] ref mpfr_t a0, [In] ref mpz_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_z_2exp")]
        internal static extern int mpfr_set_z_2exp([In, Out] ref mpfr_t a0, [In] ref mpz_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_nan")]
        internal static extern void mpfr_set_nan([In, Out] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_inf")]
        internal static extern void mpfr_set_inf([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_zero")]
        internal static extern void mpfr_set_zero([In, Out] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_f")]
        internal static extern int mpfr_set_f([In, Out] ref mpfr_t a0, [In] ref mpf_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_f")]
        internal static extern int mpfr_get_f([In, Out] ref mpf_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_si")]
        internal static extern int mpfr_set_si([In, Out] ref mpfr_t a0, int a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_ui")]
        internal static extern int mpfr_set_ui([In, Out] ref mpfr_t a0, uint a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_si_2exp")]
        internal static extern int mpfr_set_si_2exp([In, Out] ref mpfr_t a0, int a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_ui_2exp")]
        internal static extern int mpfr_set_ui_2exp([In, Out] ref mpfr_t a0, uint a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_q")]
        internal static extern int mpfr_set_q([In, Out] ref mpfr_t a0, [In] ref mpq_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set_str")]
        internal static extern int mpfr_set_str([In, Out] ref mpfr_t a0, string a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_init_set_str")]
        internal static extern int mpfr_init_set_str([In, Out] ref mpfr_t a0, string a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set4")]
        internal static extern int mpfr_set4([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2, int a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_abs")]
        internal static extern int mpfr_abs([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_set")]
        internal static extern int mpfr_set([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_neg")]
        internal static extern int mpfr_neg([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_signbit")]
        internal static extern int mpfr_signbit([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_setsign")]
        internal static extern int mpfr_setsign([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_copysign")]
        internal static extern int mpfr_copysign([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_z_2exp")]
        internal static extern int mpfr_get_z_2exp([In, Out] ref mpz_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_flt")]
        internal static extern float mpfr_get_flt([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_d")]
        internal static extern double mpfr_get_d([In] ref mpfr_t a0, mpfr_rnd_t a1);
        // Skipped mpfr_get_decimal64 - mpfr_srcptr,mpfr_rnd_t => _Decimal64
        // Skipped mpfr_get_ld - mpfr_srcptr,mpfr_rnd_t => long double
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_d1")]
        internal static extern double mpfr_get_d1([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_d_2exp")]
        internal static extern double mpfr_get_d_2exp(ref int a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        // Skipped mpfr_get_ld_2exp - long*,mpfr_srcptr,mpfr_rnd_t => long double
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_frexp")]
        internal static extern int mpfr_frexp(ref int a0, [In, Out] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_si")]
        internal static extern int mpfr_get_si([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_ui")]
        internal static extern uint mpfr_get_ui([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_str")]
        internal static extern /* char* */ IntPtr mpfr_get_str(StringBuilder a0, ref int a1, int a2, ulong a3, [In] ref mpfr_t a4, mpfr_rnd_t a5);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_get_z")]
        internal static extern int mpfr_get_z([In, Out] ref mpz_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_free_str")]
        internal static extern void mpfr_free_str(StringBuilder a0);
        // Skipped mpfr_urandom - mpfr_ptr,gmp_randstate_t,mpfr_rnd_t => int
        // Skipped mpfr_grandom - mpfr_ptr,mpfr_ptr,gmp_randstate_t,mpfr_rnd_t => int
        // Skipped mpfr_urandomb - mpfr_ptr,gmp_randstate_t => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_nextabove")]
        internal static extern void mpfr_nextabove([In, Out] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_nextbelow")]
        internal static extern void mpfr_nextbelow([In, Out] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_nexttoward")]
        internal static extern void mpfr_nexttoward([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_printf")]
        internal static extern int mpfr_printf(string a0, __arglist );
        // Skipped mpfr_asprintf - char**,__gmp_const char*,... => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sprintf")]
        internal static extern int mpfr_sprintf(StringBuilder a0, string a1, __arglist );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_snprintf")]
        internal static extern int mpfr_snprintf(StringBuilder a0, ulong a1, string a2, __arglist );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_pow")]
        internal static extern int mpfr_pow([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_pow_si")]
        internal static extern int mpfr_pow_si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_pow_ui")]
        internal static extern int mpfr_pow_ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ui_pow_ui")]
        internal static extern int mpfr_ui_pow_ui([In, Out] ref mpfr_t a0, uint a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ui_pow")]
        internal static extern int mpfr_ui_pow([In, Out] ref mpfr_t a0, uint a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_pow_z")]
        internal static extern int mpfr_pow_z([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpz_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sqrt")]
        internal static extern int mpfr_sqrt([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sqrt_ui")]
        internal static extern int mpfr_sqrt_ui([In, Out] ref mpfr_t a0, uint a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rec_sqrt")]
        internal static extern int mpfr_rec_sqrt([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add")]
        internal static extern int mpfr_add([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub")]
        internal static extern int mpfr_sub([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul")]
        internal static extern int mpfr_mul([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div")]
        internal static extern int mpfr_div([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add_ui")]
        internal static extern int mpfr_add_ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub_ui")]
        internal static extern int mpfr_sub_ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ui_sub")]
        internal static extern int mpfr_ui_sub([In, Out] ref mpfr_t a0, uint a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_ui")]
        internal static extern int mpfr_mul_ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_ui")]
        internal static extern int mpfr_div_ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ui_div")]
        internal static extern int mpfr_ui_div([In, Out] ref mpfr_t a0, uint a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add_si")]
        internal static extern int mpfr_add_si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub_si")]
        internal static extern int mpfr_sub_si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_si_sub")]
        internal static extern int mpfr_si_sub([In, Out] ref mpfr_t a0, int a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_si")]
        internal static extern int mpfr_mul_si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_si")]
        internal static extern int mpfr_div_si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_si_div")]
        internal static extern int mpfr_si_div([In, Out] ref mpfr_t a0, int a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add_d")]
        internal static extern int mpfr_add_d([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, double a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub_d")]
        internal static extern int mpfr_sub_d([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, double a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_d_sub")]
        internal static extern int mpfr_d_sub([In, Out] ref mpfr_t a0, double a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_d")]
        internal static extern int mpfr_mul_d([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, double a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_d")]
        internal static extern int mpfr_div_d([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, double a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_d_div")]
        internal static extern int mpfr_d_div([In, Out] ref mpfr_t a0, double a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sqr")]
        internal static extern int mpfr_sqr([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_const_pi")]
        internal static extern int mpfr_const_pi([In, Out] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_const_log2")]
        internal static extern int mpfr_const_log2([In, Out] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_const_euler")]
        internal static extern int mpfr_const_euler([In, Out] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_const_catalan")]
        internal static extern int mpfr_const_catalan([In, Out] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_agm")]
        internal static extern int mpfr_agm([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_log")]
        internal static extern int mpfr_log([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_log2")]
        internal static extern int mpfr_log2([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_log10")]
        internal static extern int mpfr_log10([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_log1p")]
        internal static extern int mpfr_log1p([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_exp")]
        internal static extern int mpfr_exp([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_exp2")]
        internal static extern int mpfr_exp2([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_exp10")]
        internal static extern int mpfr_exp10([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_expm1")]
        internal static extern int mpfr_expm1([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_eint")]
        internal static extern int mpfr_eint([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_li2")]
        internal static extern int mpfr_li2([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp")]
        internal static extern int mpfr_cmp([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp3")]
        internal static extern int mpfr_cmp3([In] ref mpfr_t a0, [In] ref mpfr_t a1, int a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_d")]
        internal static extern int mpfr_cmp_d([In] ref mpfr_t a0, double a1);
        // Skipped mpfr_cmp_ld - mpfr_srcptr,long double => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmpabs")]
        internal static extern int mpfr_cmpabs([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_ui")]
        internal static extern int mpfr_cmp_ui([In] ref mpfr_t a0, uint a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_si")]
        internal static extern int mpfr_cmp_si([In] ref mpfr_t a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_ui_2exp")]
        internal static extern int mpfr_cmp_ui_2exp([In] ref mpfr_t a0, uint a1, int a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_si_2exp")]
        internal static extern int mpfr_cmp_si_2exp([In] ref mpfr_t a0, int a1, int a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_reldiff")]
        internal static extern void mpfr_reldiff([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_eq")]
        internal static extern int mpfr_eq([In] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sgn")]
        internal static extern int mpfr_sgn([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_2exp")]
        internal static extern int mpfr_mul_2exp([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_2exp")]
        internal static extern int mpfr_div_2exp([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_2ui")]
        internal static extern int mpfr_mul_2ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_2ui")]
        internal static extern int mpfr_div_2ui([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_2si")]
        internal static extern int mpfr_mul_2si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_2si")]
        internal static extern int mpfr_div_2si([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, int a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rint")]
        internal static extern int mpfr_rint([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_round")]
        internal static extern int mpfr_round([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_trunc")]
        internal static extern int mpfr_trunc([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ceil")]
        internal static extern int mpfr_ceil([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_floor")]
        internal static extern int mpfr_floor([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rint_round")]
        internal static extern int mpfr_rint_round([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rint_trunc")]
        internal static extern int mpfr_rint_trunc([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rint_ceil")]
        internal static extern int mpfr_rint_ceil([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_rint_floor")]
        internal static extern int mpfr_rint_floor([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_frac")]
        internal static extern int mpfr_frac([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_modf")]
        internal static extern int mpfr_modf([In, Out] ref mpfr_t a0, [In, Out] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_remquo")]
        internal static extern int mpfr_remquo([In, Out] ref mpfr_t a0, ref int a1, [In] ref mpfr_t a2, [In] ref mpfr_t a3, mpfr_rnd_t a4);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_remainder")]
        internal static extern int mpfr_remainder([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fmod")]
        internal static extern int mpfr_fmod([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_ulong_p")]
        internal static extern int mpfr_fits_ulong_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_slong_p")]
        internal static extern int mpfr_fits_slong_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_uint_p")]
        internal static extern int mpfr_fits_uint_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_sint_p")]
        internal static extern int mpfr_fits_sint_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_ushort_p")]
        internal static extern int mpfr_fits_ushort_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_sshort_p")]
        internal static extern int mpfr_fits_sshort_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_uintmax_p")]
        internal static extern int mpfr_fits_uintmax_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fits_intmax_p")]
        internal static extern int mpfr_fits_intmax_p([In] ref mpfr_t a0, mpfr_rnd_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_extract")]
        internal static extern void mpfr_extract([In, Out] ref mpz_t a0, [In] ref mpfr_t a1, uint a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_swap")]
        internal static extern void mpfr_swap([In, Out] ref mpfr_t a0, [In, Out] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_dump")]
        internal static extern void mpfr_dump([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_nan_p")]
        internal static extern int mpfr_nan_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_inf_p")]
        internal static extern int mpfr_inf_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_number_p")]
        internal static extern int mpfr_number_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_integer_p")]
        internal static extern int mpfr_integer_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_zero_p")]
        internal static extern int mpfr_zero_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_regular_p")]
        internal static extern int mpfr_regular_p([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_greater_p")]
        internal static extern int mpfr_greater_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_greaterequal_p")]
        internal static extern int mpfr_greaterequal_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_less_p")]
        internal static extern int mpfr_less_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_lessequal_p")]
        internal static extern int mpfr_lessequal_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_lessgreater_p")]
        internal static extern int mpfr_lessgreater_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_equal_p")]
        internal static extern int mpfr_equal_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_unordered_p")]
        internal static extern int mpfr_unordered_p([In] ref mpfr_t a0, [In] ref mpfr_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_atanh")]
        internal static extern int mpfr_atanh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_acosh")]
        internal static extern int mpfr_acosh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_asinh")]
        internal static extern int mpfr_asinh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cosh")]
        internal static extern int mpfr_cosh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sinh")]
        internal static extern int mpfr_sinh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_tanh")]
        internal static extern int mpfr_tanh([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sinh_cosh")]
        internal static extern int mpfr_sinh_cosh([In, Out] ref mpfr_t a0, [In, Out] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sech")]
        internal static extern int mpfr_sech([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_csch")]
        internal static extern int mpfr_csch([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_coth")]
        internal static extern int mpfr_coth([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_acos")]
        internal static extern int mpfr_acos([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_asin")]
        internal static extern int mpfr_asin([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_atan")]
        internal static extern int mpfr_atan([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sin")]
        internal static extern int mpfr_sin([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sin_cos")]
        internal static extern int mpfr_sin_cos([In, Out] ref mpfr_t a0, [In, Out] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cos")]
        internal static extern int mpfr_cos([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_tan")]
        internal static extern int mpfr_tan([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_atan2")]
        internal static extern int mpfr_atan2([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sec")]
        internal static extern int mpfr_sec([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_csc")]
        internal static extern int mpfr_csc([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cot")]
        internal static extern int mpfr_cot([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_hypot")]
        internal static extern int mpfr_hypot([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_erf")]
        internal static extern int mpfr_erf([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_erfc")]
        internal static extern int mpfr_erfc([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cbrt")]
        internal static extern int mpfr_cbrt([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_root")]
        internal static extern int mpfr_root([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, uint a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_gamma")]
        internal static extern int mpfr_gamma([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_lngamma")]
        internal static extern int mpfr_lngamma([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_lgamma")]
        internal static extern int mpfr_lgamma([In, Out] ref mpfr_t a0, ref int a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_digamma")]
        internal static extern int mpfr_digamma([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_zeta")]
        internal static extern int mpfr_zeta([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_zeta_ui")]
        internal static extern int mpfr_zeta_ui([In, Out] ref mpfr_t a0, uint a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fac_ui")]
        internal static extern int mpfr_fac_ui([In, Out] ref mpfr_t a0, uint a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_j0")]
        internal static extern int mpfr_j0([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_j1")]
        internal static extern int mpfr_j1([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_jn")]
        internal static extern int mpfr_jn([In, Out] ref mpfr_t a0, int a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_y0")]
        internal static extern int mpfr_y0([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_y1")]
        internal static extern int mpfr_y1([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_yn")]
        internal static extern int mpfr_yn([In, Out] ref mpfr_t a0, int a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_ai")]
        internal static extern int mpfr_ai([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, mpfr_rnd_t a2);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_min")]
        internal static extern int mpfr_min([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_max")]
        internal static extern int mpfr_max([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_dim")]
        internal static extern int mpfr_dim([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_z")]
        internal static extern int mpfr_mul_z([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpz_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_z")]
        internal static extern int mpfr_div_z([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpz_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add_z")]
        internal static extern int mpfr_add_z([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpz_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub_z")]
        internal static extern int mpfr_sub_z([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpz_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_z_sub")]
        internal static extern int mpfr_z_sub([In, Out] ref mpfr_t a0, [In] ref mpz_t a1, [In] ref mpfr_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_z")]
        internal static extern int mpfr_cmp_z([In] ref mpfr_t a0, [In] ref mpz_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_mul_q")]
        internal static extern int mpfr_mul_q([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpq_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_div_q")]
        internal static extern int mpfr_div_q([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpq_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_add_q")]
        internal static extern int mpfr_add_q([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpq_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_sub_q")]
        internal static extern int mpfr_sub_q([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpq_t a2, mpfr_rnd_t a3);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_q")]
        internal static extern int mpfr_cmp_q([In] ref mpfr_t a0, [In] ref mpq_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_cmp_f")]
        internal static extern int mpfr_cmp_f([In] ref mpfr_t a0, [In] ref mpf_t a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fma")]
        internal static extern int mpfr_fma([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, [In] ref mpfr_t a3, mpfr_rnd_t a4);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_fms")]
        internal static extern int mpfr_fms([In, Out] ref mpfr_t a0, [In] ref mpfr_t a1, [In] ref mpfr_t a2, [In] ref mpfr_t a3, mpfr_rnd_t a4);
        // Skipped mpfr_sum - mpfr_ptr,mpfr_ptr *__gmp_const,unsigned long,mpfr_rnd_t => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_free_cache")]
        internal static extern void mpfr_free_cache(  );
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_subnormalize")]
        internal static extern int mpfr_subnormalize([In, Out] ref mpfr_t a0, int a1, mpfr_rnd_t a2);
        // Skipped mpfr_strtofr - mpfr_ptr,__gmp_const char *,char **,int,mpfr_rnd_t => int
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_get_size")]
        internal static extern ulong mpfr_custom_get_size(int a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_init")]
        internal static extern void mpfr_custom_init(/* void* */ IntPtr a0, int a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_get_significand")]
        internal static extern /* void* */ IntPtr mpfr_custom_get_significand([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_get_exp")]
        internal static extern int mpfr_custom_get_exp([In] ref mpfr_t a0);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_move")]
        internal static extern void mpfr_custom_move([In, Out] ref mpfr_t a0, /* void* */ IntPtr a1);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_init_set")]
        internal static extern void mpfr_custom_init_set([In, Out] ref mpfr_t a0, int a1, int a2, int a3, /* void* */ IntPtr a4);
        [DllImport("libmpfr-4.dll", EntryPoint = "mpfr_custom_get_kind")]
        internal static extern int mpfr_custom_get_kind([In] ref mpfr_t a0);
        // Skipped mpfr_set_sj - mpfr_t,intmax_t,mpfr_rnd_t => int
        // Skipped mpfr_set_sj_2exp - mpfr_t,intmax_t,intmax_t,mpfr_rnd_t => int
        // Skipped mpfr_set_uj - mpfr_t,uintmax_t,mpfr_rnd_t => int
        // Skipped mpfr_set_uj_2exp - mpfr_t,uintmax_t,intmax_t,mpfr_rnd_t => int
        // Skipped mpfr_get_sj - mpfr_srcptr,mpfr_rnd_t => intmax_t
        // Skipped mpfr_get_uj - mpfr_srcptr,mpfr_rnd_t => uintmax_t
        // Skipped mpfr_inp_str - mpfr_ptr,FILE*,int,mpfr_rnd_t => size_t
        // Skipped mpfr_out_str - FILE*,int,size_t,mpfr_srcptr,mpfr_rnd_t => size_t
        // Skipped mpfr_fprintf - FILE*,__gmp_const char*,... => int
        // Skipped mpfr_vprintf - __gmp_const char*,va_list => int
        // Skipped mpfr_vasprintf - char**,__gmp_const char*,va_list => int
        // Skipped mpfr_vsprintf - char*,__gmp_const char*,va_list => int
        // Skipped mpfr_vsnprintf - char*,size_t,__gmp_const char*,va_list => int
        // Skipped mpfr_vfprintf - FILE*,__gmp_const char*,va_list => int
    }
}

